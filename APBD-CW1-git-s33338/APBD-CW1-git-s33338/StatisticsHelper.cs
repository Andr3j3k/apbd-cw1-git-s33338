namespace APBD_CW1_git_s33338;

public static class StatisticsHelper
{
    public static int Square(int number)
    {
        return number * number;
    }
 
    public static int Cube(int number)
    {
        return number * number * number;
    }
    
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }
 
        int sum = 0;
 
        foreach (int value in values)
        {
            sum += value;
        }
        return (double)sum / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
}