using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
   public class pig: Mamal,Edible,Mimic
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
        public bool ClimbTree()

        {

            return true;

        }
        public void run()

        {

            Console.WriteLine("We run fast!");

        }

        public string Mimic(string movement)

        {
            return $"I can mimic {movement}, i am smart";

        }





    }
}
