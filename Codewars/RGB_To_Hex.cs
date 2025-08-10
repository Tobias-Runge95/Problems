namespace Codewars;

public class RGB_To_Hex
{
    public static string Rgb(int r, int g, int b)
    {
        return $"{ClampAndConvert(r)}{ClampAndConvert(g)}{ClampAndConvert(b)}";
    }

    private static string ClampAndConvert(int value)
    {
        if (value < 0) value = 0;
        if (value > 255) value = 255;
        return value.ToString("X2"); // X2 = Uppercase hex, 2 digits
    }
}