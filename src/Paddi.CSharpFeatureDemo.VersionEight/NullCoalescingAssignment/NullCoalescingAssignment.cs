namespace Paddi.CSharpFeatureDemo.VersionEight.NullCoalescingAssignment
{
    internal class NullCoalescingAssignment
    {
        static void Output()
        {
            string anNullString = null;
            anNullString ??= "will be assigned";
            anNullString ??= "will not be assigned";
            string useEmptyIfNull = anNullString ?? "will not be assigned";
            _ = useEmptyIfNull;
            _ = anNullString;
        }
    }
}
