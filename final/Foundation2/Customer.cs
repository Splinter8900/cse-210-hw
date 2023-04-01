using System;

class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool InCountry() {
        return _address.InCountry();
    }

    public string Name() 
    {
        return _name; 
    }

    public Address Address () 
    {
        return _address;
    }
}