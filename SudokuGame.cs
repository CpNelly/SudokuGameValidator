using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuValidator
{
    internal class SudokuGame
    {
        public string Name { get; set; }


        public void Start()
        {
            PrintColorfulMessage($"************ {this.Name} is now running ************", ConsoleColor.Green);

            int[,] SudokuMatrix = new int[9,9];

            Console.WriteLine(@"Would you like to:
                                1) Use the Default 9X9 grid
                                2) Enter you own Data");

            Console.Write("Enter option: ");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":

                    SudokuMatrix = new int[9, 9]{
                        { 5, 3, 4, 6, 7, 8, 9, 1, 2},
                        { 6, 7, 2, 1, 9, 5, 3, 4, 8},
                        { 1, 9, 8, 3, 4, 2, 5, 6, 7},
                        { 8, 5, 9, 7, 6, 1, 4, 2, 3},
                        { 4, 2, 6, 8, 5, 3, 7, 9, 1},
                        { 7, 1, 3, 9, 2, 4, 8, 5, 6},
                        { 9, 6, 1, 5, 3, 7, 2, 8, 4},
                        { 2, 8, 7, 4, 1, 9, 6, 3, 5},
                        { 3, 4, 5, 2, 8, 6, 1, 7, 9}
                    };
                    break;

                case "2":
                    SudokuMatrix = CollectSudokukoData();
                    break;

                default:
                    Console.WriteLine("the option you selected seen to be out of range, we will proceed to using the default matrix");
                    goto case "1";
                   
            }

            PrintColorfulMessage("************ your matrix is ***********", ConsoleColor.Yellow);
            printMatrix(SudokuMatrix);
            Console.WriteLine();

            bool returnValue = SudokuValidator.IsValidSudoku(SudokuMatrix);

            if(returnValue == true)
            {
                PrintColorfulMessage("The Sudoku solution is valid", ConsoleColor.Green);
            }

            else
            {
                PrintColorfulMessage("The sudoku solution is not valid", ConsoleColor.Red);
            }


        }

        //function to collect custom grid data
        private int[,] CollectSudokukoData()
        {
            int[,] data = new int[9, 9];
            bool escapeWhileLoop = false;

            for(int row = 0; row < 9; row++)
            {
                string temp = String.Empty;
               if (row + 1 == 1)
                {
                    temp = "st";
                }
               else if(row + 1 == 2)
                {
                    temp = "nd";
                }
               else if (row  + 1 == 3)
                {
                    temp = "rd";
                }
                else {
                    temp = "th";
                }

                PrintColorfulMessage($"Enter the numbers of the {row + 1}{temp} row", ConsoleColor.Yellow);
                for (int col = 0; col < 9; col++)
                {
                    Console.Write($"Enter Grid Data, Row:[{row + 1}] Column: [{col + 1}]: ");
                    do
                    {
                        string stringData = Console.ReadLine();
                        if (int.TryParse(stringData, out int value))
                        {
                            data[row, col] = value;
                            escapeWhileLoop = true;
                        }
                        else
                        {
                            Console.WriteLine("The value entered is not a number, please enter again.");
                            escapeWhileLoop = false;
                        }
                    }
                    while (escapeWhileLoop != true);
                    
                   // data[row, col] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
               PrintColorfulMessage($"you complete the number {row + 1} row", ConsoleColor.Yellow);
            }

            return data;
        }

        private void PrintColorfulMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }


        //print grid or 9X9 matrix in sudoku format
        private void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < 9; i++)
            {
                if(i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("+-----------+-----------+-----------+");
                }
                Console.Write("|  ");
                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0 && j != 0)
                    {
                        Console.Write("|  ");
                    }
                        Console.Write(matrix[i, j] + "  ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

    }
}
