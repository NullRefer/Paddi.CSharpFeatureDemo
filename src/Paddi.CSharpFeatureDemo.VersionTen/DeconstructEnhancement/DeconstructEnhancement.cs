namespace Paddi.CSharpFeatureDemo.VersionTen.DeconstructEnhancement;

internal class DeconstructEnhancement
{
    private record TestRecord(string Name, int Age);

    internal void Run()
    {
        var name = "name1";
        Console.WriteLine(name);

        TestRecord record = new("NAME", 1);

        (name, var age) = record;
        Console.WriteLine(name + age);
    }
}
