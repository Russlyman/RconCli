using CommandLine;

namespace RconCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Commands>(args).WithParsed(c => c.SendRconCommand());
        }
    }
}