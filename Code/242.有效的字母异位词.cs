/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */
using System.Collections.Generic;

// @lc code=start
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return s.OrderBy(x => x).SequenceEqual(t.OrderBy(x => x));
    }
}
// @lc code=end

