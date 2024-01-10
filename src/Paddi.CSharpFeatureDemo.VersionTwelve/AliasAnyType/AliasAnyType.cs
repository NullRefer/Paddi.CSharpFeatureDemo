using Tuple2D = (int, int);

namespace Paddi.CSharpFeatureDemo.VersionTwelve;

internal class AliasAnyType
{
    internal static void Run()
    {
        var instance = new Tuple2D(1, 2);
        Console.WriteLine(instance);
    }
}
