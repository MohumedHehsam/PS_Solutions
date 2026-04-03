public class Solution {
    public int LengthOfLongestSubstring(string s)
   {
       HashSet<char> chars = new HashSet<char>();
       int res = 0, i = 0, j = 0 ;
       while(j<s.Length)
       {
           if (!chars.Contains(s[j]))
           { chars.Add(s[j]); }
           else
           { chars.Remove(s[i++]); continue; }

           res = res > j - i +1 ? res : j - i+1;
           j++;
       }
       return res;
   }
}
