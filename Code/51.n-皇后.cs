/*
 * @lc app=leetcode.cn id=51 lang=csharp
 *
 * [51] N 皇后
 */

// @lc code=start
using System.Collections.Generic;
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        IList<IList<string>> res=new IList<List<string>>();
        List<string> board=new List<string>();
        Backtrack(board,0,)
    }

    private void Backtrack(List<string> board,int row,IList<IList<string>> res)
    {
        if(board.Count==row)
        {
            res.Add(new List<string>(board));
            return ;
        }
        
    }
}
// @lc code=end

