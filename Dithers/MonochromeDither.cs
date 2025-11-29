using System.Drawing.Imaging;

namespace Dither.Dithers
{
    internal class MonochromeDither
    {
        private readonly DitherAlgorithm _algorithm;

        public MonochromeDither(DitherAlgorithm algorithm)
        {
            this._algorithm = algorithm;
        }

        private int ConvertRgbToGray(int r, int g, int b)
        {
            return System.Convert.ToInt32(0.299 * r + 0.587 * g + 0.114 * b);
        }

        private void SpreadError(float[,] errors, int pixelX, int error)
        {
            for (int i = 0; i < _algorithm.Formula.GetLength(0); i++)
                for (int j = 0; j < _algorithm.Formula.GetLength(1); j++)
                {
                    int diffY = i - _algorithm.StartPixelPositionInFormulaY;
                    int diffX = j - _algorithm.StartPixelPositionInFormulaX;

                    if (_algorithm.Formula[i, j] == 0 || (j == _algorithm.StartPixelPositionInFormulaX && i == _algorithm.StartPixelPositionInFormulaY)) continue;

                    int x = pixelX + diffX;
                    int y = diffY;

                    if (x >= 0 && x < errors.GetLength(1) && y >= 0 && y < errors.GetLength(0))
                    {
                        float coefficient = (float)_algorithm.Formula[i, j];
                        errors[y, x] += error * coefficient;
                    }
                }
        }

        private void shiftUpMatrix(float[,] errors)
        {
            for (int i = 0; i < errors.GetLength(0); i++)
            {
                for (int j = 0; j < errors.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        errors[i, j] = 0;
                        continue;
                    }
                    errors[i - 1, j] = errors[i, j];
                    errors[i, j] = 0;
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
                float[,] errors = new float[_algorithm.Formula.GetLength(0), width];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixelColor = UnsafeBitmapHelper.GetPixelUnsafe(bmpData, x, y);
                        int grayscale = ConvertRgbToGray(pixelColor.R, pixelColor.G, pixelColor.B) + System.Convert.ToInt32(errors[0, x]);
                        int color = (grayscale > 128) ? 255 : 0;
                        int error = grayscale - color;
                        SpreadError(errors, x, error);
                        UnsafeBitmapHelper.SetPixelUnsafe(bmpData, x, y, Color.FromArgb(color, color, color));
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
