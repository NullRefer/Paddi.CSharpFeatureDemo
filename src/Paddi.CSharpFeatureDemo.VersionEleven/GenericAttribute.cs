using System.Reflection;

namespace Paddi.CSharpFeatureDemo.VersionEleven;

internal class GenericAttribute<T> : Attribute
{
    public T DefValue { get; init; }

    public GenericAttribute(T defValue) => DefValue = defValue;
}

internal class DemoWithDefaultValue
{
    [Generic<string>("NameTheDefaultValueWithAttribute")]
    public string DefWithJack { get; set; }

    [Generic<int>(1)]
    public int DefWithInt { get; set; }

    internal void Run()
    {
        var attr = typeof(DemoWithDefaultValue).GetProperty("DefWithJack");
        var attValue = attr.GetCustomAttribute<GenericAttribute<string>>();
        var att2Value = typeof(DemoWithDefaultValue).GetProperty("DefWithInt").GetCustomAttribute<GenericAttribute<int>>();
        Console.WriteLine(attValue.DefValue);
        Console.WriteLine(att2Value.DefValue);
    }
}
