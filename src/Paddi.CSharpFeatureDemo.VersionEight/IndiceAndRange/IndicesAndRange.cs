namespace Paddi.CSharpFeatureDemo.VersionEight.IndicesAndRange
{
    internal class IndicesAndRange
    {
        static void Output()
        {
            var words = new string[]
            {
                "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"
            };
            var firstWord = words[0];
            var lastWord = words[^1];

            var firstTwoWords = words[..2];
            var lastTwoWords = words[^2..];
            System.Console.WriteLine(firstWord);
            System.Console.WriteLine(lastWord);
            System.Console.WriteLine(firstTwoWords);
            System.Console.WriteLine(lastTwoWords);
        }
    }
}
