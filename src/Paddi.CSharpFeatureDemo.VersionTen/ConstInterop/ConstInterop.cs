namespace Paddi.CSharpFeatureDemo.VersionTen.ConstInterop;

internal class ConstInterop
{
    private string Name { get; set; }

    private const string _warn1 = "WARN";

    private const string _warn2 = $"WARN-{_warn1}";
}
