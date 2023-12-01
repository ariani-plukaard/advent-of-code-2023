namespace advent_of_code_2023.day1;

public class Trebuchet
{
    public int CalibrationTotal()
    {
        var values = CalibrationValues("/Users/Ariani.Plukaard/personal/repos/advent-of-code-2023/src/day1/Input1.txt");
        var total = values.Sum();
        Console.WriteLine(total);
        return total;
    }
    
    private List<int> CalibrationValues(string textFile)
    {
        var lines = File.ReadAllLines(textFile);

        var calibrationValues = new List<int>();
        foreach (var line in lines)
        {
            calibrationValues.Add(GetCalibrationValueDigitOnly(line));
        }

        Console.WriteLine("Total values read: " + calibrationValues.Count);
        return calibrationValues;
    }

    private int GetCalibrationValueDigitOnly(string line)
    {
        var numberString = new string(line.Where(char.IsDigit).ToArray());
        return int.Parse(numberString.First() + "" + numberString.Last());
    }
}