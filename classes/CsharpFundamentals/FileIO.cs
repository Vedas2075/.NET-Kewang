using System.IO;

public class FileIO
{
    public void ReadFileFromDisk(string path)
    {
        string fileText = File.ReadAllText(path);        
        Console.WriteLine(fileText);
    }

    public void CreateFileToDisk()
    {
        // Verbatim character @
        string filePath = @"C:\Users\cl_si\OneDrive\Pictures\dotnet_demo.txt";
        File.WriteAllText(filePath, "This is second file");
        ReadFileFromDisk(filePath);
    }
}