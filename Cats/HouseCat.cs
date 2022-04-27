using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }

        public double WeightCat { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        //added constructor
        public HouseCat(string name)
        {
             Name = name;
        }

        //added constructor
        public HouseCat(double weightcat)
        {
            WeightCat = weightcat;
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return Hungry && Tired;
        }

        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); // prints "Meow!"
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
