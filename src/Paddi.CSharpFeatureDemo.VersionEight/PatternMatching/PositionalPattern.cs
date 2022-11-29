namespace Paddi.CSharpFeatureDemo.VersionEight.PatternMatching
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);

        public static Quadrant GetQuadrant(Point p) => p switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            _ => Quadrant.Unknown
        };
    }

    internal enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder,
    }
}
