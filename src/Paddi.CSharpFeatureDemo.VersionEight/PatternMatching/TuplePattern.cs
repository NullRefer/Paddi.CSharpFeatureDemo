namespace Paddi.CSharpFeatureDemo.VersionEight.PatternMatching
{
    internal class TuplePattern
    {
        public static string GetCoordinate(int x, int y) => (x, y) switch
        {
            (0, 0) => "origin",
            (1, 1) => "first quadrant",
            (-1, 1) => "second quadrant",
            (-1, -1) => "third quadrant",
            (1, -1) => "fourth quadrant",
            _ => "not recognized"
        };
    }
}