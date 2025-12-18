using OurChat;
using System.Drawing;

namespace ConsoleSergei2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            while (true)
            {
                string command = Console.ReadLine();
                string output = application.CommandHandler(command);
                if (output != null)
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}