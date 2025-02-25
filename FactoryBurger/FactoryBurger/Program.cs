namespace FactoryBurger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BurgerFactory factory = new BurgerFactory();
            Console.WriteLine("Please enter your burger preference");
            Console.WriteLine("Plain\nCheese\nChicken\nFish");
            String selectedBurger = Console.ReadLine();

            IBurger burger = factory.getBurger(selectedBurger);

            Console.WriteLine($"Bun:\t{burger.getBun()}");
            Console.WriteLine($"Condiments:\t{burger.getCondiments()}");
            Console.WriteLine($"Patty:\t{burger.getPatty()}");
            Console.WriteLine($"Bun:\t{burger.getBun()}");


            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
