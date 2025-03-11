namespace WhatsInTheBoxComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harddrive = new Leaf("Hard Drive", 2000, 2);
            var ram = new Leaf("RAM", 1000, 2);
            var cpu = new Leaf("CPU", 6000, 1);
            var mouse = new Leaf("Mouse", 1500, 4);
            var keyboard = new Leaf("Keyboard", 1700, 4);

            Composite motherboard = new Composite("Motherboard", 5000, 1);
            Composite cabinet = new Composite("Cabinet", 2000, 1);
            Composite peripherals = new Composite("Peripherals", 0, 0);
            Composite computer = new Composite("Computer", 350, 1);

            motherboard.AddItem(cpu);
            motherboard.AddItem(ram);

            cabinet.AddItem(harddrive);
            cabinet.AddItem(motherboard);

            peripherals.AddItem(mouse);
            peripherals.AddItem(keyboard);

            computer.AddItem(cabinet);
            computer.AddItem(peripherals);

            Console.WriteLine("Total price is: R" + computer.CalculatePrice());
            Console.ReadLine();
        }
    }
}
