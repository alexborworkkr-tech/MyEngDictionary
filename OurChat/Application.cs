using OurChat.Controllers;
using OurChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat
{
    public class Application
    {
        private DataBase _database;
        public User AuthorizedUser;
        public int Status;
        public TeachingController teachingcontroller;

        public Application()
        {
            _database = new DataBase();
            _database.Seed();
        }

        public string CommandHandler(string commandLine)
        {
            if (Status == 0)
            {
                try
                {
                    switch (commandLine)
                    {
                        case "help":
                            return "Available commands:\n" +
                                "login - to log in\n" +
                                "register - to register";
                        case "login":
                            var loginController = new LoginController();
                            AuthorizedUser = loginController.Login(this, _database);
                            break;
                        case "register":
                            var registerController = new RegisterController();
                            AuthorizedUser = registerController.Registration(_database, this);
                            break;
                        default:
                            return "Unknown command!";
                    }
                }
                catch (Exception ex)
                {
                    return "Sorry something went wrong....\n" + ex;
                }

                if (AuthorizedUser != null)
                {
                    Status = 1;

                    string helloMessage = AuthorizedUser.ToSringAsProfile();

                    teachingcontroller = new TeachingController(this, _database);
                    helloMessage += "\n\n" + teachingcontroller.NextWord();

                    return helloMessage;
                }
            }
            else if (Status == 1)
            {
                switch (commandLine)
                {
                    case "logout":
                        Status = 0;
                        AuthorizedUser = null;
                        break;
                    default:
                        return teachingcontroller.NextWord(commandLine);
                }
            }

            return null;
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string error)
        {
            Console.WriteLine(error);
        }

        public void Error(string error)
        {
            Console.WriteLine(error);
        }
    }
}
