using System;
using System.Collections.Generic;
using System.Text;
using zoo.Classes;
using zoo.Interface;

namespace zoo.classes
{
   public  class PolarBear : Mammal,Hunt
    {

        public override string color => "white";

        public override int legs => 4;


        public override void Eat()
        {
            Console.WriteLine("I love eating");
        }
        public string Hunt(Edible food)
        {
            return food.type;

        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep on the ground.");
        }
        public string Speak(string name)

        {
            return name;
       }

        
    }
}
