using System;
using System.Collections.Generic;
using System.Linq;

public class Sudoku
{
  public static bool ValidateSolution(int[][] board)
    {
        for (int i = 0; i < 9; ++i)
        {
            var row = new List<int>();
            for (int j = 0; j < 9; ++j) row.Add(board[i][j]);
            if (!Check(row)) return false;

            var col = new List<int>();
            for (int j = 0; j < 9; ++j) col.Add(board[j][i]);
            if (!Check(col)) return false;

            var block = new List<int>();
            int br = (i / 3) * 3;
            int bc = (i % 3) * 3;
            for (int j = 0; j < 9; ++j) block.Add(board[br + j / 3][bc + j % 3]);
            if (!Check(block)) return false;
        }

        return true;
    }

    private static bool Check(IList<int> checkList)
    {
        return checkList.Distinct().Count() == 9;
    }
}
