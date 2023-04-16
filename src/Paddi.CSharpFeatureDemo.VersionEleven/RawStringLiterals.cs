namespace Paddi.CSharpFeatureDemo.VersionEleven;

internal class RawStringLiterals
{
    internal void Run()
    {
        var stringInterop = "This is inserted";

        var rawString1 = $"""
            This is a raw string representation.
            As you can see, I can easily enter multiple lines in one string.
            Although, string interpolation is illegal - {stringInterop};
            """;

        var rawString2 = $$"""
            This is another raw string representation.
            It use string interpolation with double '{' with leading double `{`.
            stringInterop - {{stringInterop}}
            """;
        Console.WriteLine(rawString1);
        Console.WriteLine(rawString2);
    }
}
