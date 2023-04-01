using System;

// Define the base class for events
class Event {
    // Private fields
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    // Constructor
    public Event(string title, string description, DateTime date, string time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Getters for private fields
    public string GetTitle() {
        return title;
    }

    public string GetDescription() {
        return description;
    }

    public DateTime GetDate() {
        return date;
    }

    public string GetTime() {
        return time;
    }

    public Address GetAddress() {
        return address;
    }

    // Methods to generate marketing messages
    public virtual string StandardDetails() {
        return "Event: " + title + "\n" +
               "Description: " + description + "\n" +
               "Date: " + date.ToShortDateString() + "\n" +
               "Time: " + time + "\n" +
               "Address: " + address.ToString();
    }

    public virtual string FullDetails() {
        return StandardDetails();
    }

    public virtual string ShortDescription() {
        return "Event Type: Unknown\n" +
               "Title: " + title + "\n" +
               "Date: " + date.ToShortDateString();
    }
}