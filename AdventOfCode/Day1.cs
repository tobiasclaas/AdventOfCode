namespace AdventOfCode;

internal class Day1
{
    internal readonly string path = "C:\\Users\\tobia\\git\\AdventOfCode\\AdventOfCode\\PuzzleInput\\day1.txt";

    public int Solve()
    {
        var fileContents = FileHelper.ReadFile(path);
        var lines = fileContents.Split("\r\n");

        var array1 = new int[lines.Length];
        var array2 = new int[lines.Length];

        var strings = new string[2];
        for (int i = 0; i < lines.Length; i++)
        {
            strings = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            array1[i] = int.Parse(strings[0]);
            array2[i] = int.Parse(strings[1]);
        }

        Array.Sort(array1);
        Array.Sort(array2);

        var total = 0;
        for (int i = 0;  i < array1.Length; i++)
        {
            total += Math.Abs(array1[i] - array2[i]);
        }

        return total;
    }
}
