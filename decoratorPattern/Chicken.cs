class Chicken : MenuItemDecorator
{
    public Chicken(MenuItem item) : base(item)
    {
        Description = "Chicken";
        Price = 40;
    }
}