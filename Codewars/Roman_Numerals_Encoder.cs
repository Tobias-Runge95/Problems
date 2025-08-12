namespace Codewars;

public class Roman_Numerals_Encoder
{
    public static string Solution(int number)
    {
        if (number < 1 || number > 3999)
            throw new ArgumentOutOfRangeException("number", "Value must be between 1 and 3999.");

        // Mapping of values to Roman numerals
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        var result = string.Empty;

        for (int i = 0; i < values.Length; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                result += numerals[i];
            }
        }

        return result;
        
    }
}