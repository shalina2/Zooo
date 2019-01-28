using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interface;

namespace zoo.classes
{
   public  class HummingBird : Bird,Mimic
    {
        public override void Eat()
        {
            Console.WriteLine("I am not that into eating,but i do to survive");
        }
        public string Mimic(string movement)

        {

            return "I like Talking";

        }

        public override void Sleep()
        {
           Console.WriteLine("I love sleeping,i guess");
        }
    }
}
