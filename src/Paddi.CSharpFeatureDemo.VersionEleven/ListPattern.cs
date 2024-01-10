namespace Paddi.CSharpFeatureDemo.VersionEleven;

internal class ListPattern
{
    internal void Run()
    {
        var arr = new int[] { 1, 2, 3, 4, 5 };
        if (arr is [1, .., 4])
        {
            Console.WriteLine("Arr is 1..4");
        }

        if (arr is [1, .., 5])
        {
            Console.WriteLine("Arr is 1..5");
        }
    }
}
