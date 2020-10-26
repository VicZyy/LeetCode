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
        if (s.Length != t.Length)
        {
            return false;
        }
        int[] charArr = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charArr[s[i] - 'a']++;
            charArr[t[i] - 'a']--;
        }
        foreach (var num in charArr)
        {
            if (num != 0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

