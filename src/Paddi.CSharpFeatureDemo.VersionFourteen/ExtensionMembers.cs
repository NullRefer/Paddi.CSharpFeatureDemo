namespace Paddi.CSharpFeatureDemo.VersionFourteen;

public static class ExtensionMembers
{
    public static void Run()
    {
        int[] array = [1, 2, 3, 4, 5];
        Console.WriteLine(array.IsEmpty); // Output: False
    }
}

public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T> source)
    {
        public bool IsEmpty => !source.Any();
    }
}
