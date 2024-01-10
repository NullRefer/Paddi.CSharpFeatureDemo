namespace Paddi.CSharpFeatureDemo.VersionTwelve;

internal class DefaultLambdaParameter
{
    internal static void Run()
    {
        var increment = (int x, int y = 1) => x + y;
        var result = increment(10, 10);
        Console.WriteLine($"Increment with 10: {result}");
        result = increment(10);
        Console.WriteLine($"Increment with default: {result}");
    }
}
