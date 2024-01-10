namespace Paddi.CSharpFeatureDemo.VersionTwelve;

internal class PrimaryConstructor(string prop1, int prop2, long prop3, DateTime prop4)
{
    private string Prop1 => prop1;
    private int Prop2 => prop2;
    private long Prop3 => prop3;
    private DateTime Prop4 => prop4;

    internal static void Run()
    {
        var instance = new PrimaryConstructor("1", 2, 3, DateTime.Now);
        Console.WriteLine(instance);
    }

    public override string ToString() => $"prop1: {prop1}, prop2: {prop2}, prop3: {prop3}, prop4: {prop4}";
}
