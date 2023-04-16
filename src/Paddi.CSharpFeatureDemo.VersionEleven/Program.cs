using Paddi.CSharpFeatureDemo.VersionEleven;

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. RawStringLiterals
        new RawStringLiterals().Run();

        // 2. Generic attribute
        new DemoWithDefaultValue().Run();

        // 3. New line string interpolation
        new NewLineStringInterpolation().Run();

        // 4. List pattern
        new ListPattern().Run();

        // 5. file local class
        _ = new JustInThisFile() { Name = "Just in file" };

        // 6. require member
        // var wrongIns = new ClassThatAllMemberIsRequired(); // it generate a compile error which indicates that `Name` property is not initilized
        var rightIns = new ClassThatAllMemberIsRequired { Name = "Is is required" };
        Console.WriteLine(rightIns.Name);


    }
}

file class JustInThisFile
{
    public string Name { get; set; }
}

internal class ClassThatAllMemberIsRequired
{
    internal required string Name { get; set; }
}

