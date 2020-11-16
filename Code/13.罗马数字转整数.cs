/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution
{
    private Dictionary<string, int> baseDict = new Dictionary<string, int> {
            { "I", 1},
            { "V", 5},
            { "X", 10},
            { "L", 50},
            { "C", 100},
            { "D", 500},
            { "M", 1000},
        };

    //特殊元素和数值对应表
    private Dictionary<string, int> exceptDict = new Dictionary<string, int>
        {
            { "IV", 4},
            { "IX", 9},
            { "XL", 40},
            { "XC", 90},
            { "CD", 400},
            { "CM", 900},
        };

    public int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length;)
        {
            //查看是否是连续的特殊字符串
            if (i < s.Length - 1 && exceptDict.ContainsKey(s.Substring(i, 2)))
            {
                result = result + exceptDict[s.Substring(i, 2)];
                i = i + 2;
            }
            else
            {
                result = result + baseDict[s.Substring(i, 1)];
                i = i + 1;
            }
        }
        return result;
    }
}
// @lc code=end

