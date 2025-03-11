class Bacon : MenuItemDecorator
{
    public Bacon(MenuItem Decorator) : base(Decorator)
    {
        Description = "Bacon";
        Price = 15;
    }
}