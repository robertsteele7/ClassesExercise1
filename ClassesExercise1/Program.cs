using System;
using System.Collections.Generic;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy,};

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            
            }
        }
    }
}
