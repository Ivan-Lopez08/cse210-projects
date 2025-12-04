public class Product
{
    private string _productName;
    private string _productId;
    private float _unitPrice;
    private int _quantity;

    public Product(string name, string id, float price, int qty)
    {
        _productName = name;
        _productId = id;
        _unitPrice = price;
        _quantity = qty;
    }

    public float ComputeTotal()
    {
        return (_unitPrice * _quantity);
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetId()
    {
        return _productId;
    }
}