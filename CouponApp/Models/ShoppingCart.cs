namespace CouponApp.Models;

public class ShoppingCart
{
    public List<Item> Items = new List<Item>();
    public double TotalCost = 0;

    public void AddToItems(Item item)
    {
        Items.Add(item);
        TotalCost += item.Price;
        Items.Sort((a ,b) => b.Price.CompareTo(a.Price));
    }
}