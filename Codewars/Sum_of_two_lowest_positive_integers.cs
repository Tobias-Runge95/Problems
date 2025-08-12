namespace Codewars;

public class Sum_of_two_lowest_positive_integers
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int lowest = numbers[0], secondLowest = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < lowest)
            {
                secondLowest = lowest; // shift the old lowest
                lowest = num;
            }
            else if (num > lowest && num < secondLowest)
            {
                secondLowest = num;
            }
        }

        return lowest + secondLowest;
    }
}