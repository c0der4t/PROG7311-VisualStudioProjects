using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBurger
{
    public class CheeseBurger : IBurger
    {
        public string getBun()
        {
            return "wheat";
        }

        public string getCondiments()
        {
            return "cheese";
        }

        public string getPatty()
        {
            return "beef";
        }
    }
}
