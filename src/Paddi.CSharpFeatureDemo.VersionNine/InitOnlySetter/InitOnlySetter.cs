namespace Paddi.CSharpFeatureDemo.VersionNight.InitOnlySetter
{
    internal class InitOnlySetter
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    internal class InitOnlySetterDemo
    {
        internal static void Run()
        {
            var initOnlySetter = new InitOnlySetter()
            {
                Name = "init only once",
                Age = 18,
            };
            // following result in compiling error:
            // initOnlySetter.Name = "cannot assigned again";
        }
    }
}
