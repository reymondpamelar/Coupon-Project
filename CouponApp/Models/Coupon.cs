namespace CouponApp.Models;

public class Coupon
{
    public Coupon(string name, double value)
    {
        Name = name;
        Value = value;
    }
    public string Name { get; set; }
    public double Value { get; set; }
}