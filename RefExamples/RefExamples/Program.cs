using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace RefExamples
{
    class Program
    {
        public class Car
        {
            private Color color;
            public Color Color
            {
                get
                {
                    return color;
                }
            }

            public Car(bool random = false)
            {
                if (random)
                    SetRandomColor(ref color);
                else
                    color = Color.Black;
            }

            public Car(Color color)
            {
                this.color = color;
            }
        }
        static void SetRandomColor(ref Color color)
        {
            Random random = new Random();
            color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        static ref Car getRandomCar(Car[] cars)
        {
            return ref cars[(new Random()).Next(cars.Length - 1)];
        }

        static void SwapCars(ref Car car1, ref Car car2)
        {
            Car tmp = car1;
            car1 = car2;
            car2 = tmp;
        }

        static bool SwapRandomCars(Car[] cars)
        {
            if (cars.Length <= 1)
                return false;
            int randomNum = new Random().Next(cars.Length - 1);
            SwapCars(ref cars[randomNum], ref cars[randomNum + 1]);
            return true;
        }
        
        static void AddCarWithRandomColor(ref Car[] cars)
        {
            Car[] tmpCars = new Car[cars.Length + 1];
            for(int i = 0; i < cars.Length; i++)
                tmpCars[i] = cars[i];
            tmpCars[cars.Length] = new Car(true);
            cars = tmpCars;
        }

        static void Main(string[] args)
        {

        }
    }
}
