// See https://aka.ms/new-console-template for more information

using CouponApp.Models;
using CouponApp.Models.Interfaces;

var Inventory = new Inventory();
Inventory.AddToItems(new Item("banana", 1));
Inventory.AddToItems(new Item( "pencil" , 2 ));
Inventory.AddToItems(new Item( "cup" , 3 ));
Inventory.AddToItems(new Item( "coffee" , 5 ));

var CouponList = new CouponList();
CouponList.AddToCoupons(new Coupon("HalfOff", 0.5));
CouponList.AddToCoupons(new Coupon("Bogo50", 0.5));

Console.WriteLine("Welcome to the store! Here are our available items:");
foreach (var item in Inventory.Items)
{
    Console.WriteLine(" * " + item.Name + ", $" + item.Price);
}

ShoppingCart Cart = new ShoppingCart();
while (true)
{
    Console.WriteLine("What item would you like to add? If you are done type: done");
    string itemToAdd = Console.ReadLine();
    var exists = false;
    if (itemToAdd == "done")
    {
        break;
    }
    foreach (var item in Inventory.Items)
    {
        if (itemToAdd == item.Name)
        {
            exists = true;
            Cart.AddToItems(new Item(item.Name, item.Price));
        }
    }

    if (!exists)
    {
        Console.WriteLine("This item does not exist!");
        continue;
    }
    
    Console.WriteLine("[In cart]");
    foreach (var item in Cart.Items)
    {
        Console.WriteLine(" * " + item.Name + ", $" + item.Price);
    }
    Console.WriteLine("Total Cost = $"+ Cart.TotalCost);
}

Console.WriteLine("What coupon would you like to add?");
foreach (var coupon in CouponList.Coupons)
{
    Console.WriteLine(" - " + coupon.Name + ", " + coupon.Value);
}

string CouponToAdd = Console.ReadLine();

CouponList.ApplyCoupon(Cart, CouponToAdd);

Console.WriteLine("[In cart]");
foreach (var item in Cart.Items)
{
    Console.WriteLine(" * " + item.Name + ", $" + item.Price);
}
Console.WriteLine("Total Cost = $"+ Cart.TotalCost);

