using OurChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Controllers
{
    public class TeachingController
    {
        private DataBase _db;
        private Word _currentWord;

        public TeachingController(Application application, DataBase db)
        {
            _db = db;
        }

        public string NextWord()
        {
            var oldWord = _currentWord;

            var rand = new Random();
            int maxWords = _db.Words.Count;
            int nextIndex = rand.Next(1, maxWords) - 1;
            var nextWord = _db.Words[nextIndex];

            _currentWord = nextWord;
            return "\n" + nextWord.EnglishName + "\nrussian: " + nextWord.RussianName;
        }

        public string NextWord(string commandLine)
        {
            switch (commandLine)
            {
                case "info":
                    return GetMostHardWord();
                case "y":
                case "d":
                    _currentWord.Knowledge++;
                    break;
                case "n":
                case "a":
                    _currentWord.Knowledge--;
                    break;
                default:
                    return "Unknown command!";
            }

            return NextWord();
        }

        private string GetMostHardWord()
        {
            int min = 0;
            Word match = null;
            foreach (var word in _db.Words)
            {
                if (word.Knowledge < min)
                {
                    min = word.Knowledge;
                    match = word;
                }
            }

            if (match == null)
            {
                return "no data";
            }

            return match.EnglishName;
        }
    }
}
