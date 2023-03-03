using CouponApp.Models.Interfaces;

namespace CouponApp.Models;

public class Item: IItems
{
    public Item(string name , double price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public double Price { get; set; }
}