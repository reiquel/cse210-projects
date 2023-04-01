// Define the derived class for outdoor gatherings
class OutdoorGathering : Event {
    // Private fields
    private string weatherForecast;

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address,
                             string weatherForecast) : base(title, description, date, time, address) {
        this.weatherForecast = weatherForecast;
    }

    // Getter for private field
    public string GetWeatherForecast() {
        return weatherForecast;
    }

    // Override the FullDetails method to include outdoor gathering-specific information
    public override string FullDetails() {
        return "Event: " + GetTitle() + "\n" +
               "Description: " + GetDescription() + "\n" +
               "Date: " + GetDate().ToShortDateString() + "\n" +
               "Time: " + GetTime() + "\n" +
               "Address: " + GetAddress().ToString() + "\n" +
               "Type: Outdoor Gathering\n" +
               "Weather Forecast: " + weatherForecast;
    }
}