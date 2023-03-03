namespace CouponApp.Models;

public class Inventory
{
    public List<Item> Items = new List<Item>();

    public void AddToItems(Item item)
    {
        Items.Add(item);
    }
}