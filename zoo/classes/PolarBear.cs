using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
   public  class PolarBear : Mamal,Walk
    {
        public override sleep()
        {
            Console.WriteLine("polarbear do sleep");
        }
        public string Breastfeed()
        {
            Console.WriteLine("female polarbear breastfeed");

        }
        public string Walk(crawl place )
        {
            return place.type;
        }
    }
}
