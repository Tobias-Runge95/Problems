namespace Codewars;

public class Least_Larger
{
    public static int LeastLarger(int[] a, int i)
    {
        int s = a[i], c = int.MaxValue;
        for (int j = 0; j < a.Length; j++)
        {
            if (a[j] > s && a[j] < c)
            {
                c = a[j];
            }
        }

        Console.WriteLine($"c: {c}, max: {int.MaxValue}");
        if (c == int.MaxValue)
        {
            return -1;
        }

        return c;
    }
}