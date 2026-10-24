using System;

public class Product
{
    private string _name;
    private string _productsID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productsID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productsID;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}