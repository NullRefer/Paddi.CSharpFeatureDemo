namespace Paddi.CSharpFeatureDemo.VersionThirteen;

public static class FieldKeyword
{
    public static void Run()
    {
        var person = new Person
        {
            MyProperty = 10
        };
        Console.WriteLine($"Use field for init value of 10 but get value of {person.MyProperty}");
    }

    private class Person
    {
        public int MyProperty
        {
            get => field;
            set => field = value * 2;
        }
    }
}

