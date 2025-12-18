using OurChat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Controllers
{
    public class LoginController
    {
        public User Login(Application application, DataBase db)
        {
            int i = 0;
            
            while (true)
            {
                application.WriteLine("Insert your login, please");
                string login = application.ReadLine();

                application.WriteLine("Now password");
                string password = application.ReadLine();

                foreach (var item in db.Users)
                {
                    if (item.Login == login && item.Password == password)
                    {
                        application.WriteLine(item.ToSringAsProfile());
                        return item;
                    } 
                }

                i++;
                if (i>=3)
                {
                    application.Error("You put wrong password more than 3 times!");
                    return null;
                }
            }
        }
    }
}
