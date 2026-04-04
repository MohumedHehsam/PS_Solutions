public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint res = 0;
        for (int i = 1; i < 32; i++)
        {
            res += n % 2;
            res <<= 1;
            n >>= 1;
        }
        res += n % 2;
        return res;
    }
}
