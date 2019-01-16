using System;
using zoo.classes;
using zoo.Interface;

namespace zoo
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PolarBear polarbear = new PolarBear();

            string sleep = polarbear.sleep("I usually dont sleep");
            Console.WriteLine("yes i do sleep");
            polarbear.Breastfeed();

           
            pig pig = new pig();
            pig.Eat();
            pig.Sleep();
            pig.hair();



           
        }
    }
}
