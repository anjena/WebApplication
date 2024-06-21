namespace WebApplication.nUnitTests
{
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Test Product", 10, 100);
        }

        // Tests for ProductID
        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(10000)]
        public void ProductId_AssignValue_ReturnsCorrectValue(int productId)
        {
            // Arrange
            var product = new Product(productId, "Test Product", 10, 100);

            // Act
            var actual = product.ProductId;

            // Assert
            Assert.That(actual, Is.EqualTo(productId));
        }

        // Tests for ProductName
        [TestCase("Tea_")]
        [TestCase("Coffee Bean")]
        [TestCase("Cappuccina")]
        public void ProductName_AssignValue_ReturnsCorrectValue(string productName)
        {
            // Arrange
            var product = new Product(1, productName, 10, 100);

            // Act
            var actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(productName));
        }

        // Tests for Price
        [TestCase(1.00)]
        [TestCase(2500.00)]
        [TestCase(5000.00)]
        public void Price_AssignValue_ReturnsCorrectValue(double price)
        {
            // Arrange
            var product = new Product(1, "Test Product", price, 100);

            // Act
            var actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(price));
        }

        // Tests for Stock
        [TestCase(1)]
        [TestCase(50000)]
        [TestCase(100000)]
        public void Stock_AssignValue_ReturnsCorrectValue(int stock)
        {
            // Arrange
            var product = new Product(1, "Test Product", 10, stock);

            // Act
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(stock));
        }

        // Tests for IncreaseStock
        [TestCase(10, 10, 20)]
        [TestCase(5, 15, 20)]
        [TestCase(100, 100, 200)]
        public void IncreaseStock_AddsStockCorrectly(int initialStock, int amountToAdd, int expected)
        {
            // Arrange
            var product = new Product(1, "Test Product", 10, initialStock);

            // Act
            product.IncreaseStock(amountToAdd);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Tests for DecreaseStock
        [TestCase(20, 10, 10)]
        [TestCase(30, 15, 15)]
        [TestCase(200, 100, 100)]
        public void DecreaseStock_SubtractsStockCorrectly(int initialStock, int amountToSubtract, int expected)
        {
            // Arrange
            var product = new Product(1, "Test Product", 10, initialStock);

            // Act
            product.DecreaseStock(amountToSubtract);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}