namespace mart_management
{
    /// <summary>
    /// Builder Pattern: Provides a fluent API for step-by-step
    /// construction of Product objects.
    /// </summary>
    public class ProductBuilder
    {
        private readonly Product _product = new Product();

        public ProductBuilder SetName(string name)
        {
            _product.ProductName = name;
            return this;
        }

        public ProductBuilder SetCategory(int categoryId)
        {
            _product.CategoryID = categoryId;
            return this;
        }

        public ProductBuilder SetPricing(double unitPrice, double costPrice)
        {
            _product.UnitPrice = unitPrice;
            _product.CostPrice = costPrice;
            return this;
        }

        public ProductBuilder SetUnit(string unit)
        {
            _product.Unit = unit;
            return this;
        }

        public ProductBuilder SetReorderLevel(int level)
        {
            _product.ReorderLevel = level;
            return this;
        }

        public ProductBuilder SetStatus(string status)
        {
            _product.Status = status;
            return this;
        }

        /// <summary>
        /// Builds and returns the fully constructed Product.
        /// </summary>
        public Product Build()
        {
            return _product;
        }
    }
}
