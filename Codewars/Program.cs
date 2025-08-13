namespace Codewars;

public class Program
{
    public static void Main(string[] args)
    {
        var testValue = new[] { 1, 3, 5, 2, 4 };
        var test = Least_Larger.LeastLarger(testValue, 0);
        Console.WriteLine(test);
    }
}