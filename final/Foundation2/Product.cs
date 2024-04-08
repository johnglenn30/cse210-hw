class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public string GetProductName() => _productName;
    public string ProductName(string productName) => _productName = productName;
    public int GetProductId() => _productId;
    public int ProductId(int productId) => _productId = productId;
    public int GetPrice() => _price;
    public int Price(int price) => _price = price;
    public int GetQuantity() => _quantity;
    public int Quantity(int quantity) => _quantity = quantity;

    public double GetTotalCost() => _price * _quantity;
}