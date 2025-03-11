class Cheese : MenuItemDecorator
{
    public Cheese(MenuItem Decorator) : base(Decorator)
    {
        Description = "Cheese";
        Price = 20;
    }
}