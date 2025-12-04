public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotalOrder()
    {
        float orderTotal = 0;
        foreach(Product product in _products)
        {
            orderTotal += product.ComputeTotal();
        }

        if (_customer.InsideUSA())
        {
            orderTotal += 5;
        }
        else
        {
            orderTotal += 35;
        }

        return orderTotal;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} \n {_customer.GetAddress()}";
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Product Name  | Product ID \n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()}  |  {product.GetId()} \n";
        }

        return packingLabel;
    }

}