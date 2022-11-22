using System.Net.Http.Headers;
namespace AbstractFactory
{
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostService CreateShippingCostService();
    }

    public class BelgiumShippingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new BelgiumShippingCostService();
        }
    }
    public class FranceShippingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new FranceShippingCostService();
        }
    }

    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }

    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    public interface IShippingCostService
    {
        decimal ShippingCosts { get; }
    }

    public class BelgiumShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 20;
    }

    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 25;
    }

    public class ShippingCart
    {
        private readonly IDiscountService _discountService;

        private readonly IShippingCostService _shippingCostsService;

        private int _orderCosts;

        public ShippingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostService();

            _orderCosts = 200;

        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs={_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
        }
    }
}