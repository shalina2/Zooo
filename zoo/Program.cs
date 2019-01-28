using System;
using zoo.classes;

namespace zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //created a new object of Tiger ,Teddy is a Tiger
            PolarBear polarBear = new PolarBear();

            string name = polarBear.Speak("Ted");
            Console.WriteLine($"Hello,my name is {name}, i am a tiger");
            Console.WriteLine("My color is:" + polarBear.color);
            Console.WriteLine($"I have {polarBear.legs} legs");
            polarBear.Eat();
            polarBear.Sleep();



            //created a pig object
            Pig pig = new Pig();
            pig.name = "pupu";
            Console.WriteLine($"Hi! I am a monkey my name is {pig.name}");
            pig.Eat();
            pig.Sleep();

            Console.WriteLine("**************");
        
            //created a Owl object

            Owl owl = new Owl();
            owl.Sleep();
            owl.Eat();
            owl.sound();
            Console.WriteLine("I can fly:" + owl.fly());


            Console.WriteLine("**************");
            //created a Ostrich object

            HummingBird hummingBird = new HummingBird();
            hummingBird.Sleep();
            hummingBird.Eat();
            Console.WriteLine("I can fly:" + hummingBird.fly());
            Console.WriteLine("**************");
            Console.WriteLine("**************");
           // string foodOne = hummingBird.Hunt(Owl);
           
           
            Console.WriteLine("**************");
            Console.WriteLine(hummingBird.Mimic("kukukkuukku"));

        }
    }
}