using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interface;

namespace zoo.classes
{
   public  class Owl :Bird,Hunt
    {
     
        public override void Eat()

        {
            Console.WriteLine("I eat fish");

        }

        public string Hunt(Edible food)

        {
            return food.type; 
        }
        public override void  Sleep()

        {

            Console.WriteLine("I love to sleep");

        }


    }
}
