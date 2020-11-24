/*
 * @lc app=leetcode.cn id=46 lang=csharp
 *
 * [46] 全排列
 */

// @lc code=
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> track = new List<int>();
        BackTrack(nums, track,res);
        return res;
    }

    private void BackTrack(int[] nums, IList<int> track,IList<IList<int>> res)
    {
        if (track.Count == nums.Length)
        {
            res.Add(new List<int>(track));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (track.Contains(nums[i]))
            {
                continue;
            }
            track.Add(nums[i]);
            BackTrack(nums, track,res);
            track.RemoveAt(track.Count - 1);
        }
    }
}
// @lc code=end

