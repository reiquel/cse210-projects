class FileCreation
{
    public static void Main()
    {
        string path = @"D:\Text_Files\my_file.txt";

        // The line below will create a text file, my_file.txt, in 
        // the Text_Files folder in D:\ drive.
        // The CreateText method that returns a StreamWriter object
        using (StreamWriter sw = File.CreateText(path))
    }
}