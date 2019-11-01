﻿using System;

namespace ClassesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());

            car = new Car();

            Console.ReadLine();

        }
    }

    class Car
    {
        private string color;

        public Car()
        {
            Console.WriteLine("Constructor with no paremeter called");
        }

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            
            get
            {
                return color.ToUpper();
            }
            set
            {
                if (value == "Red")
                {
                    color = value;
                }
                else
                    Console.WriteLine("this car can only be red!");
            }
        }
    }
}
