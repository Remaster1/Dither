
namespace Dither.Dithers
{
    internal class MonochromeDither
    {
        private readonly DitherAlgorithm _algorithm;

        public MonochromeDither(DitherAlgorithm algorithm)
        {
            this._algorithm = algorithm;
        }

        private double ConvertRgbToGray(int r, int g, int b)
        {
            return 0.299 * r + 0.587 * g + 0.114 * b;
        }

        private void SpreadError(double[,] errors, int x, int y, int width, int height, double error)
        {

            for (int i = 0; i < _algorithm.Formula.GetLength(0); i++)
                for (int j = 0; j < _algorithm.Formula.GetLength(1); j++)
                {
                    int diffY = i - _algorithm.StartPixelPositionInFormulaY;
                    int diffX = j - _algorithm.StartPixelPositionInFormulaX;

                    if (_algorithm.Formula[i, j] == 0 || (j == _algorithm.StartPixelPositionInFormulaX && i == _algorithm.StartPixelPositionInFormulaY)) continue;
                    if ((diffX + x < width) && (diffX + x >= 0) &&
                        (diffY + y < height) && (diffY + y >= 0))
                        errors[y + diffY, x + diffX] += error * _algorithm.Formula[i, j];
                }
        }

        public Bitmap Convert(Bitmap original)
        {
            Bitmap bitmap = new Bitmap(original);
            double[,] errors = new double[bitmap.Height, bitmap.Width];
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    double grayscale = ConvertRgbToGray(pixelColor.R, pixelColor.G, pixelColor.B) + errors[y, x];
                    int color = (grayscale > 128) ? 255 : 0;
                    double error = grayscale - color;
                    SpreadError(errors, x, y, bitmap.Width, bitmap.Height, error);
                    bitmap.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
            return bitmap;
        }
    }

}
