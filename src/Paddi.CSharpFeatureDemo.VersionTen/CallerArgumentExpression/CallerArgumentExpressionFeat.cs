using System.Runtime.CompilerServices;

namespace Paddi.CSharpFeatureDemo.VersionTen.CallerArgumentExpression;

internal class CallerArgumentExpressionFeat
{
    internal void Run()
    {
        try
        {
            var s1 = "Tell";
            var s2 = " ";
            var s3 = "ME";
            _ = Judge(s1 + s2 + s3);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {

        }

        _ = Judge("name");
    }

    internal string Judge(string arg, [CallerArgumentExpression("arg")] string msg = null)
    {
        if (arg == "Tell ME")
        {
            throw new ArgumentException($"This is self defined error msg: {msg}", nameof(arg));
        }

        var newArg = arg + arg;
        newArg += "klfjalkfd";
        return newArg;
    }
}
