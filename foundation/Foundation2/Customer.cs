//The customer contains a name and an address.
//The name is a string, but the Address is a class.

using System.Reflection.Metadata;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name , Address theAddress)
    {
        _name = name;
        _address = theAddress;
    }

//The customer should have a method that can return whether they live in the USA or not.
//(Hint this should call a method on the address to find this.) 
    public bool IsUSA2()
    {
        return _address.IsUSA();
    }

    public string DisplayCustomer()
    {
        string myLabel = $"{_name} \n {_address.GetAddress()}";
        return myLabel;
    }



}