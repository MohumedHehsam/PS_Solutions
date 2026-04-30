public class Solution
{
    public int Reverse(int x)
    {
        long res = 0;
        int sign = 1;
        if (x < 0)
        {
            x = -x;
            sign = -1;
        }
        while (x > 0)
        {
            res *= 10; res += x % 10;
            x /= 10;
        }

        if (sign == 1 && res > int.MaxValue || sign == -1 && -res < int.MinValue)
            return 0;
        return sign * (int)res;

    }
}
