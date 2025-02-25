using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBurger
{
    public class PlainBurger : IBurger
    {
        public string getBun()
        {
            return "wheat";
        }

        public string getCondiments()
        {
            return "tomato sauce";
        }

        public string getPatty()
        {
            return "beef";
        }
    }
}
