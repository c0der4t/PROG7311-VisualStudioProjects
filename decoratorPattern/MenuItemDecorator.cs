class MenuItemDecorator : MenuItem
{

    MenuItem Decorator = null;
    protected string Description = "";
    protected decimal Price = 0;

    public MenuItemDecorator(MenuItem item){
    Decorator = item;
    }

    public override string GetDescription()
    {
        return Description + " " + Decorator.GetDescription();
    }

    public override decimal GetPrice()
    {
        return Price + Decorator.GetPrice();
    }
}
