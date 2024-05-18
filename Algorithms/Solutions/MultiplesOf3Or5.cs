namespace Algorithms_with_C_Sharp.Solutions;

public static class Kata
{
    public static int Solution(int value)
    {
        if (value <= 2) return 0;
        var total = 0;
        
        for (var i = 3; i < value; i++) 
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                total += i;
            }
        }
        return total;
    }
    
    public static int SolutionWithLinq(int value)
    {
        if (value <= 2) return 0;

        return Enumerable.Range(3, value - 2)
            .Where(i => i % 3 == 0 || i % 5 == 0)
            .Sum();
    }
}