class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void AddProduct(Product product) 
    {
        _products.Add(product);
    }
     

    public double CalculateCost()
    {
        double cost = 0;
        foreach     (var product in _products)
        {
            cost += product.GetTotalCost();
        }
        cost += _customer.IsInUSA() ? 5 : 35;
        return cost;
    }
    
    public string GetProductLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"Name: {product.GetProductName()}, Product ID: {product.GetProductId()}";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        if (_customer != null && _customer.GetAddress() != null)
        {
            return $"Customer: {_customer.GetName()}\n Address: {_customer.GetAddress().GetHomeAddress()}";
        }
        else
        {
            return "Customer info not available";
        }
    }
     

    public Customer GetCustomer() => _customer;
    public void SetCustomer(Customer customer) => _customer = customer;
}