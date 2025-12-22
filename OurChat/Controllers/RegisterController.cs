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
            application.WriteLine("Please insert your new login first");
            string login = GetLogin(db, application);
            string password = GetPassword(application);
            int age = GetAge(application);
            DateTime Birthday = GetBirthDay(application);

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
                Birthday = Birthday,
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

        public int GetAge(Application app)
        {
            string regage;

            while (true)
            {
                app.WriteLine("Now insert your age");
                regage = app.ReadLine();

                if (!int.TryParse(regage, out int result))
                {
                    app.Error("Please insert digits");
                    continue;
                }

                int age = result;

                if (age < 18)
                {
                    app.Error("You are supposed to be at least 18 years old to be in the system");
                }
                else if (age > 100)
                {
                    app.Error("You are supposed to be less than 100 years old to be in the system");
                }
                else
                {
                    return age;
                }
            }
        }

        public DateTime GetBirthDay(Application app)
        {
            DateTime birthday = default;
            while (true)
            {
                app.WriteLine("Please insert your date of birth");
                string regbirthday = app.ReadLine();
                if (DateTime.TryParse(regbirthday, out birthday))
                {
                    return birthday;   
                }
                else
                {
                    app.Error("Please, use digits");
                    continue;
                }
            }
        }
    }
}
