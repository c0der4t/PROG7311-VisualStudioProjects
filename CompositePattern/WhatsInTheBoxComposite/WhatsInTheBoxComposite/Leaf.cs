using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInTheBoxComposite
{
    public class Leaf : Items, IComponent
    {
        public Leaf(string name, int price, int quantity) 
            : base(name, price, quantity)
        {

        }

        public int CalculatePrice()
        {
            Console.WriteLine(name + " with the price " + (price*quantity));
            return price * quantity;
        }
    }
}
