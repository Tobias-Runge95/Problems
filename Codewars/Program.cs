namespace Codewars;

public class Program
{
    public static void Main(string[] args)
    {
        var testValue = new int[] { 15, 28, 4, 2, 43 };
        var test = Sum_of_two_lowest_positive_integers.sumTwoSmallestNumbers(testValue);
        Console.WriteLine(test);
    }
}