namespace Paddi.CSharpFeatureDemo.VersionFourteen;

public static class ExtensionMembers
{
    public static void Run()
    {
        int[] array = [1, 2, 3, 4, 5];
        Console.WriteLine(array.IsEmpty); // Output: False
        Console.WriteLine(IEnumerable<int>.IsEmptyMethod(array)); // Output: False
    }
}

public static class EnumerableExtensions
{
    // Extension property for class
    extension<T>(IEnumerable<T> source)
    {
        public bool IsEmpty => !source.Any();
    }

    // Extension static method for class
    extension<T>(IEnumerable<T>)
    {
        public static bool IsEmptyMethod(IEnumerable<T> source)
        {
            return !source.Any();
        }
    }
}
