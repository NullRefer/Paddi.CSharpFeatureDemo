using System.Diagnostics.CodeAnalysis;

namespace Paddi.CSharpFeatureDemo.VersionTen.LambdaEnhancement;

internal class LambdaEnhancement
{
    private record TestRecord(string Name, int Age);

    internal void Run()
    {
        // prev
        Func<string, bool> predicate = s => string.IsNullOrWhiteSpace(s);

        // now
        var pred = (string s) => string.IsNullOrWhiteSpace(s);

        Console.WriteLine(predicate.GetType() == pred.GetType());

        // explicit define the return type of lambda
        var pred2 = object (string s) => s == "name" ? 1 : "name";


        // attribute can be placed in lambda
        var pred3 = (TestRecord record, [DisallowNull] TestRecord record2) => $"{record.Name} | {record2.Name}";
    }
}
