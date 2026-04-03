
public class Solution
{
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        var res = new List<List<int>>();
        Array.Sort<int>(candidates);
        for (int i = 0; i < candidates.Length; i++)
        {
            if (i > 0 && candidates[i] == candidates[i - 1])
                continue;
            var crnt = new List<int> { candidates[i] };

            Check(candidates, candidates[i], i + 1, target, crnt, res);
        }
        return res;
    }
    void Check(int[] candidates, int sum, int index, int target, List<int> crnt, List<List<int>> res)
    {
        if (sum == target)
        { res.Add(crnt.ToList()); return; }
        if (sum > target || index >= candidates.Length)
            return;

        crnt.Add(candidates[index]);
        Check(candidates, sum + candidates[index], index + 1, target, crnt, res);
        crnt.Remove(candidates[index]);

        if (index < candidates.Length - 1 && candidates[index] == candidates[index + 1])
            index += 1;
            
        Check(candidates, sum, index + 1, target, crnt, res);
    }

}
