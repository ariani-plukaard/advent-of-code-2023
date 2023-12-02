using System.Text.RegularExpressions;

namespace advent_of_code_2023.day1;

public class Trebuchet
{
    public int CalibrationTotal(string textFile, bool withWords)
    {
        var values = CalibrationValues(textFile, withWords);
        var total = values.Sum();
        Console.WriteLine("RESULT: " + total);
        return total;
    }
    
    private List<int> CalibrationValues(string textFile, bool withWords)
    {
        var lines = File.ReadAllLines(textFile);

        var calibrationValues = new List<int>();
        foreach (var line in lines)
        {
            calibrationValues.Add(withWords
                ? GetCalibrationValue(ConvertAllWordsToDigits(line))
                : GetCalibrationValue(line));
            Console.WriteLine("#" + calibrationValues.Last());
        }
        Console.WriteLine("Total values read: " + calibrationValues.Count);
        return calibrationValues;
    }

    private int GetCalibrationValue(string line)
    {
        var numberString = new string(line.Where(char.IsDigit).ToArray());
        return int.Parse(numberString.First() + "" + numberString.Last());
    }

    private string ConvertAllWordsToDigits(string line)
    {
        line = line.Replace("one", "o1e");
        line = line.Replace("two", "t2o");
        line = line.Replace("three", "t3e");
        line = line.Replace("four", "4");
        line = line.Replace("five", "5e");
        line = line.Replace("six", "6");
        line = line.Replace("seven", "7n");
        line = line.Replace("eight", "e8t");
        line = line.Replace("nine", "n9e");
        return line;
    }

    // private string ConvertAllWordsToDigits(string line)
    // {
    //     for (var i = 0; i < line.Length; i++)
    //     {
    //         switch (line[i]) 
    //         {
    //             case 'o':
    //                 line = ConvertToDigitIfWord(line, i, "one", "1");
    //                 break;
    //             case 't':
    //                 line = ConvertToDigitIfWord(line, i, "two", "2");
    //                 line = ConvertToDigitIfWord(line, i, "three", "3");
    //                 break;
    //             case 'f':
    //                 line = ConvertToDigitIfWord(line, i, "four", "4");
    //                 line = ConvertToDigitIfWord(line, i, "five", "5");
    //                 break;
    //             case 's':
    //                 line = ConvertToDigitIfWord(line, i, "six", "6");
    //                 line = ConvertToDigitIfWord(line, i, "seven", "7");
    //                 break;
    //             case 'e':
    //                 line = ConvertToDigitIfWord(line, i, "eight", "8");
    //                 break;
    //             case 'n':
    //                 line = ConvertToDigitIfWord(line, i, "nine", "9");
    //                 break;
    //         }
    //     }
    //     // Console.Write(line + " - ");
    //     return line;
    // }
    //
    // private string ConvertToDigitIfWord(string line, int firstLetterIndex, string numWord, string digit)
    // {
    //     if (IsNumberWord(line, firstLetterIndex, numWord))
    //     {
    //         line = line.Remove(firstLetterIndex, numWord.Length).Insert(firstLetterIndex, digit + numWord.Last());
    //     }
    //
    //     return line;
    // }
    //
    // private bool IsNumberWord(string line, int firstLetterIndex, string numWord)
    // {
    //     return (firstLetterIndex <= line.Length - numWord.Length) && line.Substring(firstLetterIndex, numWord.Length).Equals(numWord);
    // }
    
    
    
}