namespace Paddi.CSharpFeatureDemo.VersionEight.StaticLocalFunction
{
    internal class StaticLocalFunction
    {
        internal static void Foo()
        {
            var resultFromLocal = LocalFunc();
            static int LocalFunc() => 2;
            _ = resultFromLocal;
        }
    }
}
