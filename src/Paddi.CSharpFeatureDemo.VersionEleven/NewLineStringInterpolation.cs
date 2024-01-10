namespace Paddi.CSharpFeatureDemo.VersionEleven
{
    internal class NewLineStringInterpolation
    {
        internal void Run()
        {
            var stringForInterop = "Name";
            var interopString = $"This line is interop {(stringForInterop == "Name"
                ? "Name in string" : "NoName")}";
            Console.WriteLine(interopString);
        }
    }
}
