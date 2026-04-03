public class Solution {
public bool CheckInclusion(string s2, string s1) //s2:substring 
{
    Dictionary<char, int> d = new Dictionary<char, int>();
    foreach (char c in s2)
        if (d.ContainsKey(c))
            d[c]++;
        else
            d.Add(c, 1);

    int i = 0;
    while (i < s1.Length)
    {
        if (d.ContainsKey(s1[i]))
        {
            int clone = i;
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            int j = 0;
            while (j < s2.Length && i < s1.Length && d.ContainsKey(s1[i]))
            {
                if (!d2.ContainsKey(s1[i]))
                    d2.Add(s1[i], 1);
                else if (++d2[s1[i]] > d[s1[i]])
                     break ;

                i++; j++;
            }

            if (j == s2.Length)
                return true;
            else
                i = clone ;
        }
        i++;
    }
    return false;
}
}
