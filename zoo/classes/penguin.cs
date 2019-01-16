using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
    class penguin:Bird
    {
        public string type { get => "penguin"; set => GetType(); }



        public override void Eat()

        {

            Console.WriteLine("I eat fish");

        }

      

        public override bool fly()

        {

            return false;

        }
        public override bool swim()

        {

            return false;

        }


    }
}
