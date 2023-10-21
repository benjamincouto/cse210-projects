public class Product
{
    private string _name;
    private string _iD;
    private double _price;
    private int _quantity;

    public Product (string name, string iD, double price, int quantity)
    {
        _name = name;
        _iD = iD;
        _price = price;
        _quantity = quantity;
    }

    public double Price()
    {
        double price = _price * _quantity;
        return price;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _iD;
    }
}