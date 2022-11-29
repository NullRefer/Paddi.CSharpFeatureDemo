using System;

namespace Paddi.CSharpFeatureDemo.VersionEight.ReadonlyMember
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }


        // public readonly void Translate(int xOffset, int yOffset)
        // {
        //     // following assign will introduce an compiling error
        //     // cause no changes should be made in readonly method
        //     X += xOffset;
        //     Y += yOffset;
        // }

        public readonly override string ToString() => $"{X}, {Y} is {Distance} from the origin";
    }
}