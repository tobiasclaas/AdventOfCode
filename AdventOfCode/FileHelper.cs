namespace AdventOfCode;

internal static class FileHelper
{
    public static string ReadFile(string fileName)
    {
        var fileContent = File.ReadAllText(fileName);
        return fileContent;
    }

}

