using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using homework_5_6;

namespace France
{
    public class Paris : city
    {
        public string name;
        public int population;

        public int Population { get; }
        public Paris()
        {
            name = "Paris";
            population = 2161000;
        }
    }
}
