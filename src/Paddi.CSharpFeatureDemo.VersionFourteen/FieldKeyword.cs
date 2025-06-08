namespace Paddi.CSharpFeatureDemo.VersionFourteen;

public static class FieldKeyword
{

    public static void Run()
    {
        var demo = new MyClass
        {
            IntProperty = 5
        };
        Console.WriteLine(demo.IntProperty); // Output: 10
    }

    private class MyClass
    {
        public int IntProperty
        {
            get => field;
            set => field = 2 * value;
        }
    }
}
