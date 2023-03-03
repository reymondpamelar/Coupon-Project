namespace CouponApp.Models.Interfaces;

public interface ICouponList
{
    List<Coupon> Coupons { get; set; }
    void AddToCoupons();
    void ApplyCoupon();
}