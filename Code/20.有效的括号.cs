/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public bool IsValid(string s)
    {
        //判空
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        //非空
        else
        {
            //长度不是偶数
            if (s.Length % 2 != 0)
            {
                return false;
            }
            //是偶数
            else
            {
                Stack<char> charStack = new Stack<char>();
                char temp;
                foreach (var bracket in s)
                {
                    //栈为空且第一个字符不是左括号
                    if (charStack.Count == 0 && (bracket == ')' || bracket == ']' || bracket == '}'))
                    {
                        return false;
                    }
                    else
                    {
                        //左括号入栈
                        if ((bracket == '(' || bracket == '[' || bracket == '{'))
                        {
                            charStack.Push(bracket);
                        }
                        //又括号出栈对比
                        else
                        {
                            temp = charStack.Pop();
                            if ((temp == '(' && bracket != ')') || (temp == '[' && bracket != ']') || (temp == '{' && bracket != '}'))
                            {
                                return false;
                            }
                        }
                    }
                }
                //判断最终
                return charStack.Count == 0;
            }
        }
    }
}
// @lc code=end

