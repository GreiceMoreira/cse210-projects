//Contains the name, product id, price, and quantity of each product.
//The total cost of this product is computed by multiplying the price per unit and 
//the quantity. (If the price per unit was $3 and they bought 5 of them, the product 
//total cost would be $15.)

using System.Numerics;

public class Product
{
    public string _name { get; private set; }
    public int _productId { get; private set; }
    public double _price { get; private set; }
    public int _quantity { get; private set; }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }


}