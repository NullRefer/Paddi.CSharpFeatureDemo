using System.IO;

namespace Paddi.CSharpFeatureDemo.VersionEight.UsingDeclaration
{
    internal class UsingDeclaration
    {
        internal static void ReadFile()
        {
            using var file = new StreamReader("file.txt");
            var text = file.ReadToEnd();
        }
    }
}
