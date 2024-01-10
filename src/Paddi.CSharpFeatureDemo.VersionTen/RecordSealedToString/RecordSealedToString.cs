namespace Paddi.CSharpFeatureDemo.VersionTen.RecordSealedToString;

internal class RecordSealedToString
{
    internal record TestRecord1
    {
        internal int Value { get; set; }
        internal string Name { get; set; }

        public sealed override string ToString() => $"{Name}-{Value}";
    }

    internal record TestRecord2 : TestRecord1
    {
        public new string ToString() => Name;
    }

    internal void Run()
    {
        var record1 = new TestRecord1 { Name = "age", Value = 1 };

        var record2 = new TestRecord2 { Name = "age", Value = 2 };

        Console.WriteLine(record1); // age-1
        Console.WriteLine(record2); // age-2

        Console.WriteLine(record1.ToString()); // age-1
        Console.WriteLine(record2.ToString()); // age
    }
}
