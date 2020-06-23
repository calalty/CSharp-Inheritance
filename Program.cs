using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car beepNoise = new Car();
            beepNoise.beep();

            Console.WriteLine("--------------");

            Car calsCar = new Car();
            calsCar.boot = true;
            calsCar.color = "blue";
            calsCar.doors = 5;
            calsCar.registrationPlates = "N00B5";
            calsCar.horsepower = 100.50;
            Console.WriteLine(calsCar.boot);
            Console.WriteLine(calsCar.color);
            Console.WriteLine(calsCar.doors);
            Console.WriteLine(calsCar.registrationPlates);
            Console.WriteLine(calsCar.horsepower);

            Console.WriteLine("--------------");

            Motorbike dansMotorbike = new Motorbike(0, "TOYSRUS", true, 1.5);
            Console.WriteLine(dansMotorbike.doors);
            Console.WriteLine(dansMotorbike.brand);
            Console.WriteLine(dansMotorbike.handlebars);
            Console.WriteLine(dansMotorbike.cc);





        }
    }
}
