public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool?[] canReach = new bool?[s.Length + 1];
        canReach[s.Length] = true;

        ReadOnlySpan<char> ss = s;



        return Check(ss, wordDict, canReach, 0);
    }

    private bool Check(ReadOnlySpan<char> ss, IList<string> wordDict, bool?[] canReach, int i)
    {
        if (canReach[i] is not null)
        {
            if (canReach[i] == true)
                return true;
            else
                return false;
        }

        foreach (var item in wordDict)
        {
            if (i + item.Length <= ss.Length && ss[i..].StartsWith(item))
            {

                if (Check(ss, wordDict, canReach, i + item.Length))
                {
                    canReach[i] = true;
                    return true;
                }

            }
        }
        canReach[i] = false;
        return false;
    }


}