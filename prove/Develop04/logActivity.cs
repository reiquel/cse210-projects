using System;

    public class LogActivity
    {
        public static void Log()
        {
            Console.WriteLine("Total activities completed: {0}", Activity.TotalActivities);
        }
    }