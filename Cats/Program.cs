using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!
            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);      // prints true
            Console.WriteLine(garfield.Hungry);
            Console.WriteLine(garfield.Family);
            Console.WriteLine("~~~~~~~~~~~~~");
            garfield.Sleep();
            Console.WriteLine(garfield.Tired);
            Console.WriteLine(garfield.Hungry);
            Console.WriteLine(garfield.Species);

            Console.WriteLine("~~~~~~~~~~~~~");
            //Below line will not compile as HouseCat need 2 parameters: name & weight
            //Compilation err
            HouseCat mittens = new HouseCat(8.4);
            Console.WriteLine(mittens.WeightCat);

            Console.WriteLine("~~~~~~~~~~~~~");
            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);   // prints 13

            Console.WriteLine("*********************");
            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(plainCat.Noise()); // prints "Meow!"
            Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"

        }
    }
}
