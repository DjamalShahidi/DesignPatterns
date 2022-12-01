namespace Bridge
{
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null;
        public abstract int CalculatePrice();

        public Menu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }
    public class VegetrainMenu : Menu
    {
        public VegetrainMenu(ICoupon coupon) : base(coupon)
        {

        }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }
    public class MeatBaseMenu : Menu
    {
        public MeatBaseMenu(ICoupon coupon) : base(coupon)
        {

        }
        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }

    public interface ICoupon
    {
        int CouponValue { get; }
    }

    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }
    public class OneEuroCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }
    public class TwoEuroCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}