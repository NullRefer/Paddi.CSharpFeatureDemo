namespace Paddi.CSharpFeatureDemo.VersionTwelve;

internal class CollectionExpression
{
    internal static void Run()
    {
        int[] arr = [1, 2, 3, 4, 5];
        Console.WriteLine("Init arr: ");
        foreach (var item in arr)
        {
            Console.Write(item);
        }

        Console.WriteLine();

        int[] arr2 = [.. arr, 1, 2, 3, .. arr, .. arr];
        Console.WriteLine("Combined arr: ");
        foreach (var item in arr2)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
