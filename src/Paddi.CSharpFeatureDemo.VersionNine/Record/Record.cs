namespace Paddi.CSharpFeatureDemo.VersionNight.Record
{
    internal record Record1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal record Record2(string Name, int Age);

    internal record Record3
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    internal class RecordDemo
    {
        internal void Run()
        {
            var record1 = new Record1 { Name = "John", Age = 30 };
            var record2 = new Record2("John", 30);
            var record3 = new Record3 { Name = "John", Age = 30 };
            // record3.Name = "";//illegal operation
            System.Console.WriteLine(record1.Name + " " + record1.Age);
            System.Console.WriteLine(record2.Name + " " + record2.Age);
            System.Console.WriteLine(record3.Name + " " + record3.Age);

            // value equality
            var r1 = new Record2("John", 30);
            var r2 = new Record2("John", 30);
            System.Console.WriteLine(r1 == r2); // outputs "True"
            System.Console.WriteLine(ReferenceEquals(r1, r2)); // outputs "False"
        }
    }
}
