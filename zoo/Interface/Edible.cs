using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Interface
{
   public interface Edible
    {
        string type { get; set; }
        void run();
    }
}
