
public class Solution
{
    static Dictionary<char, List<char>> dict = new()
    {
        
        { '2', new List<char>{ 'a', 'b', 'c' } },
        { '3', new List<char>{ 'd', 'e', 'f' } },
        { '4', new List<char>{ 'g', 'h', 'i' } },
        { '5', new List<char>{ 'j', 'k', 'l' } },
        { '6', new List<char>{ 'm', 'n', 'o' } },
        { '7', new List<char>{ 'p', 'q', 'r', 's' } },
        { '8', new List<char>{ 't', 'u', 'v' } },
        { '9', new List<char>{ 'w', 'x', 'y', 'z' } }
    };
    public List<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if(digits=="")
        return res;
        BackTrace(digits, 0, new StringBuilder(""),res);
        return res;

    }
    void BackTrace(string digits, int index, StringBuilder crnt, List<string> res)
    {
        if (index == digits.Length)
        { res.Add(crnt.ToString()); return; }
        foreach (var x in dict[digits[index]])
        {
            crnt.Append(x);
            BackTrace(digits, index + 1, crnt, res);
            crnt.Remove(crnt.Length - 1, 1);
        }
    }

}
