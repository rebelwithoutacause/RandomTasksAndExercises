using System;
using System.Text;

namespace BoxData
{
    public class Box
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public Box(double length, double width, double height)
        {
            if (length <= 0) throw new ArgumentException("Length cannot be zero or negative.");
            if (width <= 0) throw new ArgumentException("Width cannot be zero or negative.");
            if (height <= 0) throw new ArgumentException("Height cannot be zero or negative.");

            Length = length;
            Width = width;
            Height = height;
        }

        public double SurfaceArea()
            => 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

        public double Volume()
            => Length * Width * Height;

        public override string ToString()
            => $"Surface Area - {SurfaceArea():F2}\nVolume - {Volume():F2}";
    }
}
