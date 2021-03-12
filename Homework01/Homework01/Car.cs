using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01
{
    public enum Motorization
    {
        Gas,
        Diesel,
        Electric,
        Hybrid,
        Unknown
    }
    public enum Manufacter
    {
        Volvo,
        Kia,
        Hyundai,
        Toyota,
        Subaru,
        Ford,
        Dacia,
        UTB,
        Unknown
    }
    public enum Model
    {
        Micro,
        Sedan,
        CUV,
        SUV,
        Hatchback,
        Roadster,
        Pickup,
        Van,
        Coupe,
        Supercar,
        Minivan,
        Truck,
        U650,
        Unknown
    }
    public enum Packages
    {
        Entry,
        Plus,
        Premium,
        Sport,
        Farmer,
        Unknown
    }
    public class Car
    {
        public static int counter;
        public Manufacter manufacter;
        public Model model;
        public String color;
        public Motorization motorization;
        public Packages package;

        public Car()
        {
            this.manufacter = Manufacter.Unknown;
            this.model = Model.Unknown;
            this.color = "Unknown";
            this.motorization = Motorization.Unknown;
            this.package = Packages.Unknown;
            counter++;
        }
        public Car(Manufacter manufacter, Model model, String colorName, Motorization motorizationType ,Packages package)
        {
            this.manufacter = manufacter;
            this.model = model;
            this.color = colorName;
            this.motorization = motorizationType;
            this.package = package;
            counter++;

        }
        public static int GetNumOfInstances()
        {
            return counter;
        }
        public void CarModelsPrint()
        {
            
                Console.WriteLine(this.color + " " + this.manufacter +" "+ this.model + " with " + this.motorization + " motor " + "equiped with the " + this.package + " package");
            
        }

        public Manufacter GetManufacter()
        {
           return manufacter; 
           
        }
        public void SetManufacter(int i)
        {
            this.manufacter = (Manufacter)i;
        }

        public String GetColor()
        {
            return color;
        }
       
        public void SetColor(string colorr)
        {
            this.color = colorr;
        }

        public Model GetModel()
        {
            return model;
        }

        public void SetModel(int i)
        {
            this.model = (Model)i;
        }
        public Motorization GetMotorization()
        {
            return motorization;
        }
        public void SetMotorization(int i)
        {
            this.motorization = (Motorization)i;
        }
        public Packages GetPackages()
        {
            return package;
        }
        public void SetPackage(int i)
        {
            this.package = (Packages)i;
        }
    }
}
