/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        if(nums.Length>=2)   
        {
            for(int i=0;i<nums.Length-1;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(nums[i]+nums[j]==target)
                    {
                        return new int[2]{i,j};
                    }
                }
            }
         }
        else
        {
            return null;
        }
        return null;
    }
}
// @lc code=end

