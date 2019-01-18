using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
   public class JamacianMango:Bird
    {
        public string type { get => "Jamacianmango"; set => GetType(); }

        public override void Eat()
        {
            Console.WriteLine("I usually fly but i eat mealworms");

        }
        public override bool feather()
        {
            return true;
        }
    }
}
