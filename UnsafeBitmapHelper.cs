using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dither
{
    internal static unsafe class UnsafeBitmapHelper
    {
        /// Works ONLY with PixelFormat.Format32bppRgb!
        public static void SetPixelUnsafe(BitmapData bitmapData, int x, int y, Color color)
        {
            byte* pixel = (byte*)bitmapData.Scan0 + (x*4) + y * bitmapData.Stride;
            pixel[0] = color.B;
            pixel[1] = color.G;
            pixel[2] = color.R;
        }

        public static Color GetPixelUnsafe(BitmapData bitmapData, int x, int y)
        {
            byte* pixel = (byte*)bitmapData.Scan0 + (x * 4) + y * bitmapData.Stride;
            return Color.FromArgb(pixel[2], pixel[1], pixel[0]);
        }
    }
}
