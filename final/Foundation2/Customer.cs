
class Customer
{
    private string _name;
    private Address _address;

    public string GetName() => _name;
    public void  Name(string name) => _name = name;

    public Address GetAddress() => _address;
    public void SetAddress(Address address) => _address = address;
    public bool IsInUSA() => _address.IsInUSA();

    

    
}