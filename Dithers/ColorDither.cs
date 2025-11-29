using System.Drawing.Imaging;

namespace Dither.Dithers
{
    internal class ColorDither 
    {
        private readonly DitherAlgorithm _algorithm;
        private readonly Palette _palette;

        public ColorDither( DitherAlgorithm algorithm, Palette palette)
        {
            this._palette = palette;
            this._algorithm = algorithm;
        }

        private int CalculateColorDifference(Color originalColor, Color newColor)
        {
            int deltaR = originalColor.R - newColor.R;
            int deltaG = originalColor.G - newColor.G;
            int deltaB = originalColor.B - newColor.B;

            return (299 * deltaR * deltaR + 587 * deltaG * deltaG + 114 * deltaB * deltaB) / 1000;
        }

        private Color FindClosestColor(Color originalColor, Palette palette)
        {
            Color color = palette.Colors[0];
            int val = int.MaxValue;
            foreach (Color paletteColor in palette.Colors)
            {
                int colorDiff = CalculateColorDifference(originalColor, paletteColor);
                if (val >= colorDiff)
                {
                    val = colorDiff;
                    color = paletteColor;
                }
            }
            return color;
        }

        private void SpreadError(float[,,] errors, int pixelX, int errorR, int errorG, int errorB)
        {
           
            for (int i = 0; i < _algorithm.Formula.GetLength(0); i++)
            {
                for (int j = 0; j < _algorithm.Formula.GetLength(1); j++)
                {
                    int diffY = i - _algorithm.StartPixelPositionInFormulaY;
                    int diffX = j - _algorithm.StartPixelPositionInFormulaX;

                    if (_algorithm.Formula[i, j] == 0 || (j == _algorithm.StartPixelPositionInFormulaX && i == _algorithm.StartPixelPositionInFormulaY)) continue;

                    int x = pixelX + diffX;
                    int y = diffY;
                    
                    if(x >= 0 && x < errors.GetLength(1) && y >= 0 && y < errors.GetLength(0))
                    {
                        float coefficient = (float)_algorithm.Formula[i, j];
                        errors[y, x, 0] += errorR * coefficient;
                        errors[y, x, 1] += errorG * coefficient;
                        errors[y, x, 2] += errorB * coefficient;
                    }     
                }
            }
        }
      

        private void shiftUpMatrix(float[,,] errors)
        {
            for (int i = 0; i < errors.GetLength(0); i++)
            {
                for (int j = 0; j < errors.GetLength(1); j++)
                {
                    if(i == 0) {
                        for (int k = 0; k < errors.GetLength(2); k++)
                        {
                            errors[i, j, k] = 0;
                        }
                        continue; 
                    }
                    for (int k = 0; k < errors.GetLength(2); k++)
                    {
                        errors[i - 1, j, k] = errors[i, j, k];
                        errors[i, j, k] = 0;
                    }
                    
                }
            }
        }

        public Bitmap Convert(Bitmap original)
        {
            Bitmap bitmap = new Bitmap(original);
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            int width = bmpData.Width;
            int height = bmpData.Height;
            try
            {
                float[,,] errors = new float[_algorithm.Formula.GetLength(0), bmpData.Width, 3];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color color = UnsafeBitmapHelper.GetPixelUnsafe(bmpData, x, y);


                        int correctedR = Math.Clamp(System.Convert.ToInt32(color.R + errors[0, x, 0]), 0, 255);
                        int correctedG = Math.Clamp(System.Convert.ToInt32(color.G + errors[0, x, 1]), 0, 255);
                        int correctedB = Math.Clamp(System.Convert.ToInt32(color.B + errors[0, x, 2]), 0, 255);

                        Color newColor = FindClosestColor(Color.FromArgb(correctedR, correctedG, correctedB), _palette);

                        int errorR = correctedR - newColor.R;
                        int errorG = correctedG - newColor.G;
                        int errorB = correctedB - newColor.B;

                        SpreadError(errors, x, errorR, errorG, errorB);

                        UnsafeBitmapHelper.SetPixelUnsafe(bmpData, x, y, newColor);

                    }
                    shiftUpMatrix(errors);
                }
            }
            finally
            {
                bitmap.UnlockBits(bmpData);
            }
            return bitmap;
        }
    }
}
