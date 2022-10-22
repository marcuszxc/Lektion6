using Humanizer;
namespace TheGreatHumanizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"When is the feast? {DateTime.UtcNow.AddHours(30).Humanize()}");
            Console.WriteLine($"When is the feast? {DateTime.UtcNow.AddDays(2).Humanize()}");
        }
    }
}