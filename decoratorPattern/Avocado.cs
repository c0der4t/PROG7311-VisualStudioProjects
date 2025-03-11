class Avocado : MenuItemDecorator
{
    public Avocado(MenuItem Decorated) : base(Decorated)
    {
        Description = "Avocado";
        Price = 15;
    }
}