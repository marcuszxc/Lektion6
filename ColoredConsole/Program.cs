using ColoredConsoleLib;

namespace ColoredConsoleMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = ColoredConsole.Prompt("What is your name?");
            ColoredConsole.WriteLine("Hello " + name, ConsoleColor.Green);
        }
    }
}