using System;
using System.Collections.Generic;
using System.Text;

namespace BoxSecondAttempt
{
    public class Box
    {
        private const double SIDE_MIN_VALUE = 0;
        private const string INVALID_SIDE_MESSEGE = "{0} cannot be zero or negative.";
        private double lenght;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Lenght = length;
            this.Width = width;
            Height = height;
        }

        public double Lenght
        {
            get { return this.lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.lenght = value;
            }

        }


        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }



        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double area = 2 * (this.Lenght * this.Width) +
               2 * (this.Lenght * this.Height) +
               2 * (this.Width * this.Height);
            return area;
        }

        public double LateralSurfaceArea()
        {
            return 2 * Height * (Lenght + Width);
        }
        public double Volume()
        {
            return Height * Width * Lenght;
        }

    }
}
