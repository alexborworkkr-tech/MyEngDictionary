using OurChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat
{
    public class DataBase
    {
        public List<User> Users;

        public List<Word> Words;

        public void Seed()
        {
            Users = new List<User>();

            var u1 = new User()
            {
                Login = "boris",
                Password = "barsik",
                Birthday = new DateTime(1994, 7, 9),
                Age = 19,
                Height = 20,
            };
            Users.Add(u1);

            var u2 = new User()
            {
                Login = "sergei",
                Password = "barsik1",
                Birthday = new DateTime(2006, 7, 9),
                Age = 20,
                Height = 2000,
            };
            Users.Add(u2);

            var u3 = new User()
            {
                Login = "alexei",
                Password = "barsik3",
                Birthday = new DateTime(2003, 7, 9),
                Age = 21,
                Height = 201,
            };
            Users.Add(u3);

            // words:
            Words = new List<Word>();
            GenerateWords();
        }

        private void GenerateWords()
        {
            var w1 = new Word { EnglishName = "Cat", RussianName = "Кошка" };
            Words.Add(w1);

            var w2 = new Word { EnglishName = "Dog", RussianName = "Собака" };
            Words.Add(w2);

            var w3 = new Word { EnglishName = "Bird", RussianName = "Птица" };
            Words.Add(w3);

            var w4 = new Word { EnglishName = "Fish", RussianName = "Рыба" };
            Words.Add(w4);

            var w5 = new Word { EnglishName = "Horse", RussianName = "Лошадь" };
            Words.Add(w5);

            var w6 = new Word { EnglishName = "Cow", RussianName = "Корова" };
            Words.Add(w6);

            var w7 = new Word { EnglishName = "Pig", RussianName = "Свинья" };
            Words.Add(w7);

            var w8 = new Word { EnglishName = "Sheep", RussianName = "Овца" };
            Words.Add(w8);

            var w9 = new Word { EnglishName = "Goat", RussianName = "Коза" };
            Words.Add(w9);

            var w10 = new Word { EnglishName = "Mouse", RussianName = "Мышь" };
            Words.Add(w10);

            var w11 = new Word { EnglishName = "House", RussianName = "Дом" };
            Words.Add(w11);

            var w12 = new Word { EnglishName = "Car", RussianName = "Машина" };
            Words.Add(w12);

            var w13 = new Word { EnglishName = "Tree", RussianName = "Дерево" };
            Words.Add(w13);

            var w14 = new Word { EnglishName = "Flower", RussianName = "Цветок" };
            Words.Add(w14);

            var w15 = new Word { EnglishName = "Sun", RussianName = "Солнце" };
            Words.Add(w15);

            var w16 = new Word { EnglishName = "Moon", RussianName = "Луна" };
            Words.Add(w16);

            var w17 = new Word { EnglishName = "Star", RussianName = "Звезда" };
            Words.Add(w17);

            var w18 = new Word { EnglishName = "Water", RussianName = "Вода" };
            Words.Add(w18);

            var w19 = new Word { EnglishName = "Fire", RussianName = "Огонь" };
            Words.Add(w19);

            var w20 = new Word { EnglishName = "Earth", RussianName = "Земля" };
            Words.Add(w20);

            var w21 = new Word { EnglishName = "Air", RussianName = "Воздух" };
            Words.Add(w21);

            var w22 = new Word { EnglishName = "Book", RussianName = "Книга" };
            Words.Add(w22);

            var w23 = new Word { EnglishName = "Table", RussianName = "Стол" };
            Words.Add(w23);

            var w24 = new Word { EnglishName = "Chair", RussianName = "Стул" };
            Words.Add(w24);

            var w25 = new Word { EnglishName = "Window", RussianName = "Окно" };
            Words.Add(w25);

            var w26 = new Word { EnglishName = "Door", RussianName = "Дверь" };
            Words.Add(w26);

            var w27 = new Word { EnglishName = "Phone", RussianName = "Телефон" };
            Words.Add(w27);

            var w28 = new Word { EnglishName = "Computer", RussianName = "Компьютер" };
            Words.Add(w28);

            var w29 = new Word { EnglishName = "Clock", RussianName = "Часы" };
            Words.Add(w29);

            var w30 = new Word { EnglishName = "Bag", RussianName = "Сумка" };
            Words.Add(w30);

            var w31 = new Word { EnglishName = "Shoes", RussianName = "Обувь" };
            Words.Add(w31);

            var w32 = new Word { EnglishName = "Hat", RussianName = "Шляпа" };
            Words.Add(w32);

            var w33 = new Word { EnglishName = "Shirt", RussianName = "Рубашка" };
            Words.Add(w33);

            var w34 = new Word { EnglishName = "Pants", RussianName = "Брюки" };
            Words.Add(w34);

            var w35 = new Word { EnglishName = "Food", RussianName = "Еда" };
            Words.Add(w35);

            var w36 = new Word { EnglishName = "Bread", RussianName = "Хлеб" };
            Words.Add(w36);

            var w37 = new Word { EnglishName = "Milk", RussianName = "Молоко" };
            Words.Add(w37);

            var w38 = new Word { EnglishName = "Cheese", RussianName = "Сыр" };
            Words.Add(w38);

            var w39 = new Word { EnglishName = "Apple", RussianName = "Яблоко" };
            Words.Add(w39);

            var w40 = new Word { EnglishName = "Banana", RussianName = "Банан" };
            Words.Add(w40);

            var w41 = new Word { EnglishName = "Orange", RussianName = "Апельсин" };
            Words.Add(w41);

            var w42 = new Word { EnglishName = "City", RussianName = "Город" };
            Words.Add(w42);

            var w43 = new Word { EnglishName = "Street", RussianName = "Улица" };
            Words.Add(w43);

            var w44 = new Word { EnglishName = "Road", RussianName = "Дорога" };
            Words.Add(w44);

            var w45 = new Word { EnglishName = "River", RussianName = "Река" };
            Words.Add(w45);

            var w46 = new Word { EnglishName = "Sea", RussianName = "Море" };
            Words.Add(w46);

            var w47 = new Word { EnglishName = "Mountain", RussianName = "Гора" };
            Words.Add(w47);

            var w48 = new Word { EnglishName = "Forest", RussianName = "Лес" };
            Words.Add(w48);

            var w49 = new Word { EnglishName = "Friend", RussianName = "Друг" };
            Words.Add(w49);

            var w50 = new Word { EnglishName = "Family", RussianName = "Семья" };
            Words.Add(w50);
        }
    }
}
