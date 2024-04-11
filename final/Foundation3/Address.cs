class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    

    public string GetStreet() => _street;
    public void SetStreet(string street) => _street = street;

    public string GetCity() => _city;
    public void SetCity(string city) => _city = city;

    public string GetState() => _state;
    public void SetState(string state) => _state = state;

    public string GetCountry() => _country;
    public void SetCountry(string country) => _country = country;

    
    public string GetAddress(string street, string city, string state) => $"{street}, \n{city}, \n{state}";
    
}
