public class Solution {
    public string LongestPalindrome(string s)
    {
        if(s.Length<=1)
        return s;
        int i =1; 
        int max = 0;
        int index = 0;
        while(i<s.Length)
        {
            int odd = Odd(i,s);
            int even =Even(i-1,i,s);
            if(odd>max)
            {
                max=odd;
                index=i;
            } if(even>max)
            {
                max=even;
                index=i;
            }

            i++;
        }
            return s.Substring(index-max/2,max);
    }
    int Odd(int i,string s)
    {
        int count =0;
        int range =0;
        while(i-range>=0&&i+range<s.Length)
        {
            if(s[i+range]==s[i-range])
           { count+=2;
            range++;
           }else break;
        }
        return count-1;
    } 
    int Even(int l,int r,string s)
    {
        int count =0;
        int range =0;
        while(l-range>=0&&r+range<s.Length)
        {
            if(s[l-range]==s[r+range])
            {count+=2;
            range++;}
            else break;
        }
        return count;
    }



}
