namespace Paddi.CSharpFeatureDemo.VersionNight.PatternMatching
{
    internal class PatternMatching
    {
        internal static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        internal static bool IsLetterOrSeparator(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or '.' or ',';

        internal static void CheckNull(object o) 
        {
            if (o is null)
                throw new System.ArgumentNullException(nameof(o));
        }
    }
}