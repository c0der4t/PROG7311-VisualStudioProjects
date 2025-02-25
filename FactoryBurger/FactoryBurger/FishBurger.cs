using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBurger
{
    public class FishBurger : IBurger
    {
        public string getBun()
        {
            return "no bun";
        }

        public string getCondiments()
        {
            return "tartare";
        }

        public string getPatty()
        {
            return "fish";
        }
    }
}
