using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Interface
{
   public interface Crawl
    {
        string type { get; set; }
        void run();
    }
}
