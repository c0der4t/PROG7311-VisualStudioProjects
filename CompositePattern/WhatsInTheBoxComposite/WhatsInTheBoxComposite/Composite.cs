using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInTheBoxComposite
{
    internal class Composite : Items, IComponent
    {
        private List<Items> components;
        public Composite(string name, int price, int quantity) 
            : base(name, price, quantity)
        {
            components = new List<Items>();
        }
        public void AddItem(Items component)
        {
            components.Add(component);
        }
        public void RemoveItem(Items component)
        {
            components.Remove(component);
        }

        public int CalculatePrice()
        {
            int miniTotal = (price * quantity);
            int total = 0;
            Console.WriteLine(name + "contains the following with prices: " + miniTotal);
            foreach (IComponent item in components)
            {
                total += item.CalculatePrice();
            }
            return total + miniTotal;
        }
    }
}