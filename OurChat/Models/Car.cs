using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurChat.Models
{
    // Класс, представляющий автомобиль для обучения ООП
    public class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public string GovermentNumber;
        public float CurrentFuel;
        public float MaxFuel;

        public bool Drive(float distance)
        {
            if (Brand == "BMW")
            {
                Console.WriteLine("Сначала едьте в сервис! Engine check!");
                return false;
            }

            float fuelNeeded = distance * 0.1f; // Assume 10 km per liter
            if (fuelNeeded > CurrentFuel)
            {
                Console.WriteLine("Not enough fuel to drive the distance.");
                return false;
            }

            CurrentFuel -= fuelNeeded;
            Console.WriteLine($"Drove {distance} km. Remaining fuel: {CurrentFuel} liters.");
            return true;
        }
    }

    // Тестовый класс для демонстрации использования Car
    public class Game
    {
        public void Start()
        {
            var bmw = new Car
            {
                Brand = "BMW",
                Color = "Black",
                CurrentFuel = 20.5f,
                GovermentNumber = "A123BC",
                MaxFuel = 60f,
                Model = "X5",
            };

            bool isArrived = bmw.Drive(100f);
            if (isArrived)
            {
                // TODO БМВ приехала!
            }

            var tesla = new Car
            {
                Brand = "Tesla",
                Color = "Red",
                CurrentFuel = 50f,
                GovermentNumber = "E456DE",
                MaxFuel = 100f,
                Model = "Model S",
            };
            bool isArrived2 = tesla.Drive(100f);
            if (isArrived2)
            {
                // TODO Тесла приехала!
            }
        }
    }
}
