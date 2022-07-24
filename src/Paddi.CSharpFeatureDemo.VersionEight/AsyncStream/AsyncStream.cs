using System.Collections.Generic;
using System.Threading.Tasks;

namespace Paddi.CSharpFeatureDemo.VersionEight.AsyncStream
{
    internal class AsyncStream
    {
        internal static async Task OutputAsync()
        {
            await foreach (var item in GenerateSequenceAsync())
            {
                System.Console.WriteLine(item);
            }
        }

        internal static async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
