namespace Paddi.CSharpFeatureDemo.VersionFourteen;

public static class ExtensionMembers
{
    public static void Run()
    {
        int[] array = [1, 2, 3, 4, 5];
        Console.WriteLine(array.IsEmpty); // Output: False
        Console.WriteLine(array.IsEmptyMethod()); // Output: False
        Console.WriteLine(IEnumerable<int>.ExtendedIsEmptyMethod(array)); // Output: False
        Console.WriteLine(array.NormalIsEmptyMethod()); // Output: False
    }
}

public static class EnumerableExtensions
{
    // Extension property and method for class
    extension<T>(IEnumerable<T> source)
    {
        public bool IsEmpty => !source.Any();
        public bool IsEmptyMethod() => !source.Any();
    }

    // Extension static method for class
    extension<T>(IEnumerable<T>)
    {
        public static bool ExtendedIsEmptyMethod(IEnumerable<T> source)
        {
            return !source.Any();
        }
    }

    // Normal static method for class
    public static bool NormalIsEmptyMethod<T>(this IEnumerable<T> source) => !source.Any();
}
