using System;
using System.Collections.Generic;

namespace Homework01
{
   
    class Program
    {
        private static List<Car> myCars = new List<Car>();

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Hidden Leaf Village  Dealership:");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
           
        }

        private static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Create a new car");
            Console.WriteLine("2) Print manufactered cars");
            Console.WriteLine("3) See the number of manufactered cars");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PrintOptions();
                    CreateCar();
                    return true;
                case "2":
                    PrintManufacteredCars();
                    return true;
                case "3":
                    PrintNrOfManufacteredCars();
                    return false;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        private static void PrintNrOfManufacteredCars()
        {
            Console.WriteLine("The amount of cars manufactered is equal to :" + Car.GetNumOfInstances()+"\n");
        }

        private static void PrintManufacteredCars()
        {
            Console.WriteLine("The manufactered cars are : ");
            foreach (Car c in myCars)
            {
                c.CarModelsPrint();
            }
        }

        private static void PrintOptions()
        {
            Console.WriteLine("For creating a car we have the next possibilities: ");
            Console.WriteLine("Types of Manufacteres: ");
            foreach (Manufacter val in Enum.GetValues(typeof(Manufacter)))
            {
                Console.Write(val+" ");
            }
            Console.WriteLine("\nTypes of Models: ");
            foreach (Model val in Enum.GetValues(typeof(Model)))
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\nTypes of Packages: ");
            foreach (Packages val in Enum.GetValues(typeof(Packages)))
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\n");


        }

        private static void CreateCar()
        {
            
            Car carObject = new Car();
            Console.WriteLine("Car Color: ");
            var x = Console.ReadLine();
            carObject.SetColor(x);
            Console.WriteLine("Car Manufacter: ");
            x = Console.ReadLine();
            carObject.SetManufacter(int.Parse(x));
            Console.WriteLine("Car Model: ");
            x = Console.ReadLine();
            carObject.SetModel(int.Parse(x));
            Console.WriteLine("Car Motorization: ");
            x = Console.ReadLine();
            carObject.SetMotorization(int.Parse(x));
            Console.WriteLine("Car Package: ");
            x = Console.ReadLine();
            carObject.SetPackage(int.Parse(x));

            carObject.CarModelsPrint();
            myCars.Add(carObject);
            Console.WriteLine("\n\n");
            
        }
    }
}
