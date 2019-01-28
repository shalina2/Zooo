using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
   public  class HummingBird : Bird,Hunt
    {
        public override void Eat()
        {
            Console.WriteLine("I am not that into eating,but i do to survive");
        }
        public string Hunt(Edible food)
        {

            return food.type;
        }

        public override void Sleep()
        {
           Console.WriteLine("I love sleeping");
        }
    }
}
