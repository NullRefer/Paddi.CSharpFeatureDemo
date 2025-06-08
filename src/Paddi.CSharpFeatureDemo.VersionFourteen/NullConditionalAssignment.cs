namespace Paddi.CSharpFeatureDemo.VersionFourteen;

public static class NullConditionalAssignment
{
    public static void Run()
    {
        MyClass? demo = null;
        demo?.IntProperty = 5;
        Console.WriteLine(demo?.IntProperty ?? 0); // Output: 0

        demo = new MyClass();
        demo?.IntProperty = 5;
        Console.WriteLine(demo?.IntProperty ?? 0); // Output: 5
    }

    private class MyClass
    {
        public int IntProperty { get; set; }
    }
}
