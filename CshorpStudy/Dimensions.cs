using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CshorpStudy
{
    struct Dimensions
    {
        public double Length;
        public double Width;
        public Dimensions(double length, double width)
        {
            Length=length;
            Width=width;
        }

        public Dimensions(double length)
        {
            Length = 1;
            Width = 1;
        }

        public double Diagonal
        {
            get
            {
                return Math.Sqrt(Length * Length + Width * Width);
            }
        }
    }
}
