using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Models
{
    public class User
    {
        public string Login;
        public string Password;
        public int Age;
        public float Height;
        public DateTime Birthday;

        public string ToSringAsProfile()
        {
            string result = "HELLO!";
            result += " " + Login + " ";
            result += "YOUR HEIGHT IS " + Height + "!";
            result += "YOUR BIRTHDAY IS " + Birthday.ToString("yyyy.MM.dd") + "!";
            
            return result;
        }
    }
}
