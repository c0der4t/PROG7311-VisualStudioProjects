using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBurger
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "french bread";
        }

        public string getCondiments()
        {
            return "sweet chilli";
        }

        public string getPatty()
        {
            return "chicken";
        }
    }
}
