using OurChat;
using System.Drawing;

namespace ConsoleSergei2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            Console.WriteLine("Insert a console command:");
            Console.WriteLine("help");
            Console.WriteLine("login");
            Console.WriteLine("register");
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