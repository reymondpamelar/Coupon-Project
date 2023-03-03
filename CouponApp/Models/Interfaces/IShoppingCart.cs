namespace CouponApp.Models.Interfaces;

public interface IShoppingCart
{
    List<Item> Items { get; set; }
    double TotalCost { get; set; }
    void AddToItems();
    void AddToTotalCost();
}