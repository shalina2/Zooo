using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.classes
{
    public abstract class Bird:Animal
    {
        public virtual string sound()

        {

            return "siiii siiii ";

        }

        public virtual bool fly()
        {



            return true;

        }
    }
}
