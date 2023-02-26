public class Activity
{
    // Attribute to hold the duration of the activity
    private int duration;

    // Attribute to hold the name of the activity
    private string name;

    // Attribute to hold the description of the activity
    private string description;

    // Attribute to count number  of the activities completed
    private static int _totalActivities = 0;

    // Constructor to set the name and description of the activity
    public Activity (string name, string description)
    {
        this.name = name;
        this.description = description;
        _totalActivities++;
    }

    // Property to get and set the duration of the activity
    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    // Get and set property to get and set the name of the activity
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Get and set property to get and set the description of the activity
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

     public static int TotalActivities
        {
            get { return _totalActivities; }
        }

    // Method to display the starting message of the activity
    public void DisplayStartMessage()
    {
        Console.WriteLine("\nYou are about to begin the " + name + " activity.\n" + description + "\nPlease input the duration of the activity in seconds:");
    }

    // Method to display the ending message of the activity
    public void DisplayEndMessage()
    {
        Console.WriteLine("\nYou have completed the " + name + " activity! It was " + duration + " seconds long.\nWell done!\n");
    }
}