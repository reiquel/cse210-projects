// Define the Address class
class Address {
    // Private fields
    private string street;
    private string city;
    private string state;
    private string zipCode;

    // Constructor
    public Address(string street, string city, string state, string zipCode) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    // Override the ToString method to format the address
    public override string ToString() {
        return street + ", " + city + ", " + state + " " + zipCode;
    }
}