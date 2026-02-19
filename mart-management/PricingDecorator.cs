namespace mart_management
{
    /// <summary>
    /// Decorator Pattern: Interface for product pricing that 
    /// can be wrapped with additional behavior.
    /// </summary>
    public interface IProductPricing
    {
        double GetPrice();
        string GetDescription();
    }

    /// <summary>
    /// Base (concrete) implementation: returns the raw product unit price.
    /// </summary>
    public class BaseProductPricing : IProductPricing
    {
        private readonly double _basePrice;

        public BaseProductPricing(double basePrice)
        {
            _basePrice = basePrice;
        }

        public double GetPrice() => _basePrice;
        public string GetDescription() => "Base Price";
    }

    /// <summary>
    /// Decorator: Adds a tax percentage on top of the wrapped pricing.
    /// </summary>
    public class TaxDecorator : IProductPricing
    {
        private readonly IProductPricing _inner;
        private readonly double _taxPercent;

        public TaxDecorator(IProductPricing inner, double taxPercent)
        {
            _inner = inner;
            _taxPercent = taxPercent;
        }

        public double GetPrice()
        {
            return _inner.GetPrice() * (1 + _taxPercent / 100.0);
        }

        public string GetDescription()
        {
            return $"{_inner.GetDescription()} + Tax({_taxPercent}%)";
        }
    }

    /// <summary>
    /// Decorator: Applies a discount percentage on top of the wrapped pricing.
    /// </summary>
    public class DiscountDecorator : IProductPricing
    {
        private readonly IProductPricing _inner;
        private readonly double _discountPercent;

        public DiscountDecorator(IProductPricing inner, double discountPercent)
        {
            _inner = inner;
            _discountPercent = discountPercent;
        }

        public double GetPrice()
        {
            return _inner.GetPrice() * (1 - _discountPercent / 100.0);
        }

        public string GetDescription()
        {
            return $"{_inner.GetDescription()} - Discount({_discountPercent}%)";
        }
    }
}
