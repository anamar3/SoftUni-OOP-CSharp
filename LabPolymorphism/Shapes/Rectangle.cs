using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle: Shape
    {
        private double heigth;
        private int width;
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override string Draw()
        {
            return base.Draw() + "rectange";
        }

    }
}
