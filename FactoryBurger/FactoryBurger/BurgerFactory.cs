using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBurger
{
    public class BurgerFactory
    {

        public IBurger returnInstnace;
        public IBurger getBurger(String BurgerType)
        {

            switch (BurgerType.ToString().ToLower())
            {
                case "chicken":
                    returnInstnace = new ChickenBurger();
                break;
                case "cheese":
                    returnInstnace = new CheeseBurger();
                    break;
                case "fish":
                    returnInstnace = new FishBurger();
                    break;
                case "plain":
                    returnInstnace = new PlainBurger();
                    break;
                default:
                    returnInstnace = new PlainBurger();
                    break;
            }

            return returnInstnace;

        }

    }
}
