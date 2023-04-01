// Define the derived class for receptions
class Reception : Event {
    // Private fields
    private string rsvpEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, string time, Address address,
                      string rsvpEmail) : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    // Getter for private field
    public string GetRSVP() {
        return rsvpEmail;
    }

    // Override the FullDetails method to include reception-specific information
    public override string FullDetails() {
        return "Event: " + GetTitle() + "\n" +
               "Description: " + GetDescription() + "\n" +
               "Date: " + GetDate().ToShortDateString() + "\n" +
               "Time: " + GetTime() + "\n" +
               "Address: " + GetAddress().ToString() + "\n" +
               "Type: Outdoor Gathering\n" ;
    }
}
