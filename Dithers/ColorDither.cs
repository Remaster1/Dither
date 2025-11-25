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

        private double CalculateColorDifference(Color originalColor, Color newColor)
        {
            int deltaR = originalColor.R - newColor.R;
            int deltaG = originalColor.G - newColor.G;
            int deltaB = originalColor.B - newColor.B;

            return Math.Sqrt(deltaR * deltaR + deltaG * deltaG + deltaB * deltaB);
        }

        private Color FindClosestColor(Color originalColor, Palette palette)
        {
            Color color = palette.Colors[0];
            double val = double.MaxValue;
            foreach (Color paletteColor in palette.Colors)
            {
                double colorDiff = CalculateColorDifference(originalColor, paletteColor);
                if (val >= colorDiff)
                {
                    val = colorDiff;
                    color = paletteColor;
                }
            }
            return color;
        }

        private void SpreadError(double[,,] errors, int x, int y, int width, int height, double errorR, double errorG, double errorB)
        {

            for (int i = 0; i < _algorithm.Formula.GetLength(0); i++)
                for (int j = 0; j < _algorithm.Formula.GetLength(1); j++)
                {
                    int diffY = i - _algorithm.StartPixelPositionInFormulaY;
                    int diffX = j - _algorithm.StartPixelPositionInFormulaX;

                    if (_algorithm.Formula[i, j] == 0 || (j == _algorithm.StartPixelPositionInFormulaX && i == _algorithm.StartPixelPositionInFormulaY)) continue;
                    if ((diffX + x < width) && (diffX + x >= 0) &&
                        (diffY + y < height) && (diffY + y >= 0))
                    {
                        errors[y + diffY, x + diffX, 0] += errorR * _algorithm.Formula[i, j];
                        errors[y + diffY, x + diffX, 1] += errorG * _algorithm.Formula[i, j];
                        errors[y + diffY, x + diffX, 2] += errorB * _algorithm.Formula[i, j];
                    }    
                }
        }

        public Bitmap Convert(Bitmap original)
        {
            Bitmap bitmap = new Bitmap(original);
            double[,,] errors = new double[bitmap.Height, bitmap.Width, 3];
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    
                    int correctedR = Math.Clamp(System.Convert.ToInt32(pixelColor.R + errors[y, x, 0]), 0, 255);
                    int correctedG = Math.Clamp(System.Convert.ToInt32(pixelColor.G + errors[y, x, 1]), 0, 255);
                    int correctedB = Math.Clamp(System.Convert.ToInt32(pixelColor.B + errors[y, x, 2]), 0, 255);

                    Color newColor = FindClosestColor(Color.FromArgb(correctedR, correctedG, correctedB), _palette);

                    double errorR = correctedR - newColor.R;
                    double errorG = correctedG - newColor.G;
                    double errorB = correctedB - newColor.B;

                    SpreadError(errors, x, y, bitmap.Width, bitmap.Height, errorR, errorG, errorB);

                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
    }
}
