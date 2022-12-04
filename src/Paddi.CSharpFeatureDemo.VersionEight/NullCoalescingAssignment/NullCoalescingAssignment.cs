namespace Paddi.CSharpFeatureDemo.VersionEight.NullCoalescingAssignment
{
    internal class NullCoalescingAssignment
    {
        private static void Output()
        {
            string anNullString = null;
            anNullString ??= "will be assigned";
            anNullString ??= "will not be assigned";
            var useEmptyIfNull = anNullString ?? "will not be assigned";
            _ = useEmptyIfNull;
            _ = anNullString;
        }
    }
}
