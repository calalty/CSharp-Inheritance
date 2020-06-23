using System;
namespace Inheritance
{
    public class Vehicle
        // base class / parent class
    {
        public int doors;
        public double horsepower;
        public string color;
        public string registrationPlates;

        public void beep()
        {
            Console.WriteLine("Beeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeep");
            Console.Beep();

        }
    }

    public class Car : Vehicle
        // derived class AKA child class
    {
        public string carBrand;
        public string model;
        public bool boot;

    }
    public class Motorbike : Vehicle
    // derived class AKA child class
    {
        public string brand;
        public bool handlebars;
        public double cc;


        public Motorbike(int Doors, string Brand, bool HandleBars, double CC)
        {
            doors = Doors;
            brand = Brand;
            handlebars = HandleBars;
            cc = CC;
        }
     
        
        


    }
  
}
