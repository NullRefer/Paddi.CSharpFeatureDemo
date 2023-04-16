namespace Paddi.CSharpFeatureDemo.VersionTen.ExtendPropertyPattern;

internal class ExtendPropertyPattern
{
    private record TestRecord1(string Name, int Age);

    private record TestRecord2(string Parent, TestRecord1 InnerRecord);

    internal static void Run()
    {
        var record = new TestRecord1("Name", 1);
        var record2 = new TestRecord2("Parent", record);

        if (record is { Name: "Name" })
        {
            Console.WriteLine("Bingo");
        }

        if (record2 is { InnerRecord.Name : "Name" })
        {
            Console.WriteLine("Bingo!!!");
        }
    }
}
