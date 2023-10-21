public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
           total += product.Price(); 
        }

        return total;
    }

    public string PackagingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            string line = $"{product.GetName()} (ID: {product.GetId()})\n"; 
            label += line;           
        }

        return label;
    }

    public string ShippingLabel()
    {
        string label = $"{_customer.GetName()}\n{_customer.GetAddress()}";  

        return label;      
    }

    public bool ShippingAbroad()
    {
        return _customer.IsUsaBased();
    }

    public double TotalPrice()
    {
        double totalPrice = TotalCost();
        int internationalShippingCost = 35;
        int usaShippingCost = 5;
        if (ShippingAbroad() == true)
        {
            totalPrice += internationalShippingCost;
        }
        else
        {
            totalPrice += usaShippingCost;
        }

        return totalPrice;
    }
}