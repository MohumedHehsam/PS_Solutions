public class Solution
{
    public int CountSubstrings(string s)
    {
        int count = 0;

        //Odd Pal
        for (int i = 0; i < s.Length; i++)
        {
            int l = i, r = i;

            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r])
                    break;

                count++;
                l--; r++;
            }
        }


        //Even Pal
        for (int i = 0; i + 1 < s.Length; i++)
        {
            int l = i, r = i + 1;

            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r])
                    break;
                count++;
                l--; r++;
            }
        }

        return count;
    }
}