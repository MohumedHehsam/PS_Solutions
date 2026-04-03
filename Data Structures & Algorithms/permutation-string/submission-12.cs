
public class Solution {
public bool CheckInclusion(string s2, string s1) //s2:substring 
{
    if (s2.Length > s1.Length)
    return false;
    byte[] d1 =new byte[26];
    byte[] d2 = new byte[26];
    
    foreach (char c in s2)
        d1[c - 'a']++;

    for (int ii = 0; ii < s2.Length; ii++)
        d2[s1[ii] - 'a']++;

    if (Compare(d1, d2))
        return true;

    int i = 0,j=s2.Length-1;

    while(j<s1.Length-1)
    {
        d2[s1[i++]-'a']--;
        d2[s1[++j]-'a']++;
        if(Compare(d1,d2))
            return true;
    }

    return false;
}
public bool Compare (byte[] a, byte[] b)
{
    for (int i = 0; i < a.Length; i++)
        if (a[i] != b[i])
            return false;
    return true;
}
}
