using System;

namespace Paddi.CSharpFeatureDemo.VersionEight.PatternMatching
{
    internal class PropertyPattern
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static string Calculate(PropertyPattern pattern, int other) => pattern switch
        {
            { Age: 1 } => $"it is {other}",
            { Age: 2 } => $"it is not {other}",
            { Name: "john" } => $"it is another property",
            _ => throw new NotImplementedException()
        };
    }
}
