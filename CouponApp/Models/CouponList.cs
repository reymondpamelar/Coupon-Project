namespace CouponApp.Models.Interfaces;

public class CouponList
{
    public List<Coupon> Coupons = new List<Coupon>();

    public void AddToCoupons(Coupon coupon)
    {
        Coupons.Add(coupon);
    }

    public void ApplyCoupon(ShoppingCart Cart, string CouponToAdd)
    {
        if (CouponToAdd == "Bogo50" && Cart.Items.Count >= 2)
        {
            Cart.Items.ElementAt(1).Price *= 0.5;
            Cart.TotalCost -= Cart.Items.ElementAt(1).Price;
        }
        else
        {
            foreach (var coupon in Coupons)
            {
                if (CouponToAdd == "Bogo50")
                {
                    break;
                }
                if (CouponToAdd == coupon.Name)
                {
                    Cart.TotalCost *= coupon.Value;
                    break;
                }
            }
        }
    }
}