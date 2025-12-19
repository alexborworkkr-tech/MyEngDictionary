using OurChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Controllers
{
    internal class RegisterController
    {
        public User Registration(DataBase db, Application application)
        {
            int age = -1;
            application.WriteLine("Please insert your new login first");
            string login = GetLogin(db, application);
            string password = GetPassword(application);
            
            while (true)
            {
                application.WriteLine("Now insert age");
                var regage = application.ReadLine();

                if (int.TryParse(regage, out int result))
                {
                    age = result;
                    break;
                }
                else
                {
                    application.WriteLine("Please insert digits");
                }
            }

            if (age < 18)
            {
                application.Error("You're too young to be in system");
                return null;
            }
            else if (age > 100)
            {
                application.Error("You're too old for this, GET OUT!");
                return null;
            }

            DateTime birthday = default;
            while (true)
            {
                application.WriteLine("Please insert your date of birth");
                string regbirthday = application.ReadLine();
                if (DateTime.TryParse(regbirthday, out DateTime birthdayresult))
                {
                    birthday = birthdayresult;
                    break;
                }
                else
                {
                    application.Error("Please, use digits");
                    return null;
                }
            }

            float height = -1;
            while (true)
            {
                application.WriteLine("How tall are you? Please, use cm's");
                string regheight = application.ReadLine();
                if (float.TryParse(regheight, out float heightresult))
                {
                    height = heightresult;
                    break;
                }
                else
                {
                    application.Error("Please, use digits");
                    return null;
                }
            }


            // Boris: здесь ошибка, т.к. мы переделали наши коллекции на список Users, потом переделаем
            // эту ошибку под актуальный код
            //userLogins.Add(login);
            //userPassword.Add(regpassword);
            //userAges.Add(age);
            //userHeight.Add(height);
            //userBirthday.Add(birthday);

            User registeredUser = new User
            {
                Login = login,
                Password = password,
                Age = age,
                Height = height,
                Birthday = birthday,
            };
            db.Users.Add(registeredUser);

            return registeredUser;
        }

        public string GetLogin(DataBase db, Application application)
        {
            while (true)
            {
                application.WriteLine("Please insert your new login first");
                string login = application.ReadLine();
                bool isMatch = false;
                foreach (var user in db.Users)
                {
                    if (user.Login == login)
                    {
                        application.Error("This login is already used, choose another one");
                        isMatch = true;
                        break;
                    }
                }
                if (isMatch == false)
                {
                    return login;
                }
            }
        }

        public string GetPassword(Application application)
        {
            string regpassword;
            while (true)
            {
                application.WriteLine("Insert your new password");
                regpassword = application.ReadLine();

                if (regpassword.Length > 5)
                {
                    return regpassword;
                }
                else
                {
                    application.Error("The password must contain at least 6 symbols");
                }
            }
        }
    }
}
