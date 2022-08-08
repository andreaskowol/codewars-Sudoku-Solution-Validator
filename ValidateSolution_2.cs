using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Sudoku
{
  public static bool ValidateSolution(int[][] board)
  {
            foreach (int[] arr in board)
        {
            if (arr.Distinct().Count() != 9) { return false; }
        }

        List<int> result = new List<int>();
        for (int i = 0; i < board.Length; i++)
        {
            foreach (int[] arr in board)
            {
                result.Add(arr[i]);
            }
            if (result.Distinct().Count() != 9) { return false; }
        }

        for (int i = 0; i < 9; i =i + 3)
        {
            for (int j = 0; j < 9; j = j + 3)
            {
                if (checkBox(board, i, j) == false) { return false; }
            }
        }

        return true;
  }
  public static bool checkBox(int[][] board, int startCol, int startRow)
    {
        List<int> box = new List<int>();

        for (int i = startCol; i < startCol + 3; i++)
        {
            for (int j = startRow; j < startRow + 3; j++)
            {
                box.Add(board[i][j]);
           }
        }
        return box.Distinct().Count() == 9 ? true : false;
    }
}
