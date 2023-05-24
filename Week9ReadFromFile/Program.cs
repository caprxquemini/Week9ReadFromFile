
string fileDirectoryPath = @"C:\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

if (File.Exists(fullFilePath))
{
    Console.WriteLine($"{fileName} exists in {fileDirectoryPath}.");
    string[] ChuckJokes = File.ReadAllLines(fullFilePath);
    Console.WriteLine($"There are {ChuckJokes.Length} jokes about Chuck Norris in the file.");


    foreach (string joke in ChuckJokes)
    {
        Console.WriteLine(joke);
    }
}

else
{
    Console.WriteLine($"{fileName} was not found.");
}