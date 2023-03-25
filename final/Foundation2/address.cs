using System;
using System.Collections.Generic;

class Address {
    private string street;
    private string city;
    private string state;
    private string country;
    
    public Address(string street, string city, string state, string country) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    
    public string Street {
        get { return street; }
    }
    
    public string City {
        get { return city; }
    }
    
    public string State {
        get { return state; }
    }
    
    public string Country {
        get { return country; }
    }
    
    public bool IsInUSA() {
        return country.ToUpper() == "USA";
    }
    
    public string ToString() {
        return street + "\n" + city + ", " + state + " " + country;
    }
}
