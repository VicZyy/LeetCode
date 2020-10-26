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
        Dictionary<char, int> dictS = new Dictionary<char, int>();
        foreach (var tempChar in s)
        {
            if (dictS.ContainsKey(tempChar))
            {
                dictS[tempChar]++;
            }
            else
            {
                dictS.Add(tempChar, 1);
            }
        }
        foreach (var tempChar in t)
        {
            if (dictS.ContainsKey(tempChar))
            {
                dictS[tempChar]--;
                if(dictS[tempChar]<0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

