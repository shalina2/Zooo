using System;
using System.Collections.Generic;
using System.Text;
using zoo.Classes;
using zoo.Interface;

namespace zoo.classes
{
   public class Pig: Mammal,Edible
    {

        public override string color => "pink";

        public override int legs => 4;

        public string type { get => "pig"; set => GetType(); }

        public override void Eat()

        {

            Console.WriteLine("I eat anything,am hungry");

        }

        public override void Sleep()

        {

            Console.WriteLine("I can sleep all day everyday!");

        }

        public override bool CanSwim()

        {
            return false;

        }
      
        public void run()

        {

            Console.WriteLine("I run very slow!");

        }

        public string Mimic(string movement)

        {
            return  "i am smart";

        }





    }
}
