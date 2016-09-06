using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInformation
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            if (alpha < 0) this.alpha = 255;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public void SetColor(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public void SetColor(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }
        ///add get color methods.
        public byte GetColorRed()
        {
            return this.red;
        }
        public byte GetColorGreen()
        {
            return this.green;
        }
        public byte GetColorBlue()
        {
            return this.blue;
        }
        public byte GetColorAlpha()
        {
            return this.alpha;
        }
        public byte GetGreyscale()
        {
            byte greyscale = Convert.ToByte((red + green + blue) / 3);
            return greyscale;
        }

    }
}
