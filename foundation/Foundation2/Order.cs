using System.ComponentModel.Design;
using System.Dynamic;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;

public class Order
{
    //Contains a list of products and a customer. 
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    
    }

    public void AddInList(Product produto)
    {
        _products.Add(produto);
    }


//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
//If the customer does not live in the USA, then the shipping cost is $35.

    public int Shipping()
    {
        int shipping = 0 ;

        if (_customer.IsUSA2())
        {
            shipping = 5 ;
        }
        else
        {
            shipping = 35 ; 
        }

        return shipping;
    }

    //Can calculate the total cost of the order. 
    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.

    public double GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product p in _products)
        {
            productTotal += p.TotalCost();
        }
        double total = productTotal + this.Shipping() ;
        return total;
    }
    
    //Can return a string for the packing label. 
    //A packing label should list the name and product id of each product in the order.
    public string PackingLabel()
    {
       string list = ""; 
       foreach (Product p in _products)
       {
        list += $"{p._name} : {p._productId}\n";
       }

       return list;
    }
    
    //Can return a string for the shipping label.

    //A shipping label should list the name and address of the customer
    public string ShippingLabel()
    {
       return _customer.DisplayCustomer();
    }



}
