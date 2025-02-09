namespace Paddi.CSharpFeatureDemo.VersionThirteen;

public static class ImplicitIndexAccess
{
    public static void Run()
    {
        var person = new Person
        {
            Numbers =
            {
                [^1] = 1,
                [^2] = 2,
                [^3] = 3,
                [^4] = 4,
                [^5] = 5,
                [^6] = 6,
                [^7] = 7,
                [^8] = 8,
                [^9] = 9,
                [^10] = 10
            }
        };
        Console.WriteLine("Implicit index access:");
        foreach (var number in person.Numbers)
        {
            Console.WriteLine(number);
        }
    }

    private class Person
    {
        public int[] Numbers { get; set; } = new int[10];
    }
}
