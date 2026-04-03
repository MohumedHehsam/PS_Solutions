
public class Solution {
    public List<List<int>> Subsets(int[] nums)
    {
        var res = new List<List<int>>();
        fn(new List<int>(), nums, 0, res);
        return res;
    }

    private void fn(List<int> prev, int[] nums, int v, List<List<int>> res)
    {
        if (v == nums.Length)
           {res.Add(new List<int>(prev)); return ;}
        fn(prev, nums, v + 1, res);
        prev.Add(nums[v]);
        fn(prev, nums, v + 1, res);
        
        prev.Remove(nums[v]);
    }
}
