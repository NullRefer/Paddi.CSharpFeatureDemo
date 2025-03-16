namespace Paddi.CSharpFeatureDemo.VersionThirteen;

public static class ParamsFeature
{
    public static void Run()
    {
        var result = Add1([1, 2, 3]);
        Console.WriteLine(result);

        result = Add2([1, 2, 3]);
        Console.WriteLine(result);
    }

    private static int Add1(params ReadOnlySpan<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    private static int Add2(params IEnumerable<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}
