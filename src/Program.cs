using advent_of_code_2023.day1;
using advent_of_code_2023.tests;

//Task 1
var trebuchet = new Trebuchet();
var test = new Test();

// Console.WriteLine("TEST 1:");
// trebuchet.CalibrationTotal(
//     "/Users/Ariani.Plukaard/personal/repos/advent-of-code-2023/src/tests/test1.txt",
//     false);
// test.TestOneExpectedOutput();
//
// Console.WriteLine("\nTASK 1:");
// trebuchet.CalibrationTotal(
//     "/Users/Ariani.Plukaard/personal/repos/advent-of-code-2023/src/day1/Input1.txt",
//     false);

//Task 2
// Console.WriteLine("\nTEST 2:");
// trebuchet.CalibrationTotal(
//     "/Users/Ariani.Plukaard/personal/repos/advent-of-code-2023/src/tests/test2.txt",
//     true);
// test.TestTwoExpectedOutput();

Console.WriteLine("\nTASK 2:");
trebuchet.CalibrationTotal(
    "/Users/Ariani.Plukaard/personal/repos/advent-of-code-2023/src/day1/Input1.txt",
    true);
