namespace Paddi.CSharpFeatureDemo.VersionThirteen;

public static class NewLockObject
{
    private static readonly Lock Lock = new();

    public static void Run()
    {
        Task.Run(() => SomeParallelMethod(1));
        Task.Run(() => SomeParallelMethod(2));
        Thread.Sleep(3000);
    }

    private static void SomeParallelMethod(int times)
    {
        using (Lock.EnterScope())
        {
            Log($"{times} - Enter");
            Thread.Sleep(1000);
        }
        Log($"{times} - Exist");
    }

    private static void Log(string message)
    {
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} | Thread-{Environment.CurrentManagedThreadId} | {message}");
    }
}
