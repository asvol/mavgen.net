using System.IO;
using ManyConsole;

namespace Asv.Mavlink.Gen
{
    public class ExampleCommand:ConsoleCommand
    {
        public ExampleCommand()
        {
            IsCommand("example", "Generate files for example usage");
        }

        public override int Run(string[] remainingArguments)
        {
            Directory.CreateDirectory("in");
            File.WriteAllText("in/common.xml",Examples.common);
            File.WriteAllText("in/standard.xml", Examples.standard);
            File.WriteAllBytes("csharp.tpl", Examples.csharp);
            File.WriteAllText("generate.bat", Examples.generate);
            File.WriteAllBytes("README.md", Examples.README);
            return 0;
        }
    }
}
