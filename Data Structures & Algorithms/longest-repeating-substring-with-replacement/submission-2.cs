public class Solution {
 public int CharacterReplacement(string s, int k)
{
    int[] freq = new int[26];
    int l = 0, r = 0, maxCharFreq = 0, res = 0;
    while (r < s.Length)
    {
        freq[s[r++]-'A']++;
        maxCharFreq = Math.Max(freq[s[r - 1]-'A'], maxCharFreq);
        if (r - l - maxCharFreq > k)
        {
            freq[s[l++]-'A']--;
            maxCharFreq = freq.Max();
            continue;
        }
        res=Math.Max(res, r-l);
    }
    return res;
}
}
