using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuntionalLayer
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
        {
            "#009688" , "#009688" //, "#FF5722", "#FF9800","#9C27B0","#2196F3"
        };

        //public static Color ChangeColorBrightness(Color color, double CorrectionFactor)
        //{
        //    double red = color.R;
        //    double green = color.G;
        //    double blue = color.B;

        //    if (CorrectionFactor < 0)
        //    {
        //        CorrectionFactor = 1 + CorrectionFactor;
        //        red *= CorrectionFactor;
        //        green *= CorrectionFactor;
        //        blue *= CorrectionFactor;
        //    }
        //    else
        //    {
        //        red = (255 - red) * CorrectionFactor + red;
        //        green = (255 - green) * CorrectionFactor + green;
        //        blue = (255 - blue) * CorrectionFactor + blue;
        //    }
        //    return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        //}
    }
}
