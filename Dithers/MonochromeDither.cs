
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

        private void SpreadError(float[,] errors, int x, int y, int width, int height, int error)
        {

            for (int i = 0; i < _algorithm.Formula.GetLength(0); i++)
                for (int j = 0; j < _algorithm.Formula.GetLength(1); j++)
                {
                    int diffY = i - _algorithm.StartPixelPositionInFormulaY;
                    int diffX = j - _algorithm.StartPixelPositionInFormulaX;

                    if (_algorithm.Formula[i, j] == 0 || (j == _algorithm.StartPixelPositionInFormulaX && i == _algorithm.StartPixelPositionInFormulaY)) continue;
                    if ((diffX + x < width) && (diffX + x >= 0) &&
                        (diffY + y < height) && (diffY + y >= 0))
                        errors[y + diffY, x + diffX] += error * (float)_algorithm.Formula[i, j];
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
                float[,] errors = new float[height, width];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixelColor = UnsafeBitmapHelper.GetPixelUnsafe(bmpData,x,y);
                        int grayscale = ConvertRgbToGray(pixelColor.R, pixelColor.G, pixelColor.B) + System.Convert.ToInt32(errors[y, x]);
                        int color = (grayscale > 128) ? 255 : 0;
                        int error = grayscale - color;
                        SpreadError(errors, x, y, width, height, error);
                        UnsafeBitmapHelper.SetPixelUnsafe(bmpData,x,y,Color.FromArgb(color, color, color));
                    }
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
