namespace Paddi.CSharpFeatureDemo.VersionEight.PatternMatching
{
    internal class SwitchExpression
    {
        internal enum Rainbow
        {
            Red,
            Orange,
            Yellow,
        }

        public static string GetRainbowString(Rainbow rainbow) => rainbow switch
        {
            Rainbow.Red => "Red",
            Rainbow.Orange => "Orange",
            Rainbow.Yellow => "Yellow",
            _ => "Default",
        };
    }
}
