using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
   Public class pig:mamal,Walk
    {

        public override string bornlive => "yes";



        public string type { get => "pig"; set => GetType(); }



        public override void Eat()

        {

            Console.WriteLine("I eat anything,am hungry");

        }



        public override void Sleep()

        {

            Console.WriteLine("I can sleep all day everyday!");



        }

        public override bool hair()

        {

            return true;

        }

        public bool breastFeed()

        {

            return true;

        }



        
    }
}
