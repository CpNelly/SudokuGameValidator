using System;
using System.ComponentModel;
using System.Linq;


namespace SudokuValidator
{
    internal class SudokuValidator
    {
        public static object IsValid { get; internal set; }

        static bool IsValidGroup(int[] group)
        {
            //validates rows, colomns and 3X3 sub matrix
            //sorts the numbers the group array and returns false if there is a repeating or repeating numbers
            return group.OrderBy(n => n).SequenceEqual(Enumerable.Range(1, 9));
        }

        public static bool IsValidSudoku(int[,] grid)
        {

            //checks rows
            for(int row = 0; row < 9;  row++)
            {
                int[] rowData = new int[9];

                for (int col = 0; col < 9; col++)
                    rowData[col] = grid[row, col];

                if (!IsValidGroup(rowData))
                    return false;
                
            }

            //checks columns
            for(int col = 0; col < 9; col++) 
            {
                int[] colData = new int[9];

                for (int row = 0; row < 9; row++)
                {
                    colData[row] = grid[row, col];
                }

                if (!IsValidGroup(colData))
                    return false;
            }

            //checks 3X3 sub-matrix

            for (int boxRow = 0; boxRow < 3; boxRow++)
            {
                for (int boxCol = 0; boxCol < 3; boxCol++)
                {

                    int[] boxData = new int[9];
                    int index = 0;

                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            boxData[index++] = grid[boxRow * 3 + row, boxCol * 3 + col];
                        }
                    }

                    if(!IsValidGroup(boxData))
                        return false;
                }
            }

            return true;


        }   

    }
}
