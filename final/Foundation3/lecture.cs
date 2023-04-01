// Define the derived class for lectures
class Lecture : Event {
    // Private fields
    private string speaker;
    private int capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, string time, Address address,
                   string speaker, int capacity) : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Getter for private fields
    public string GetSpeaker() {
        return speaker;
    }

    public int GetCapacity() {
        return capacity;
    }

    // Override the FullDetails method to include lecture-specific information
    public override string FullDetails() {
        return "Event: " + GetTitle() + "\n" +
               "Description: " + GetDescription() + "\n" +
               "Date: " + GetDate().ToShortDateString() + "\n" +
               "Time: " + GetTime() + "\n" +
               "Address: " + GetAddress().ToString() + "\n" +
               "Type: Lecture\n" +
               "Speaker: " + speaker + "\n" +
               "Capacity: " + capacity;
    }
}