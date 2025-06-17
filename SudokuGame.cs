using System;
using System.Collections.Generic;
using System.Data;
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
                PrintColorfulMessage("The solution is valid", ConsoleColor.Green);
            }

            else
            {
                PrintColorfulMessage("The solution is not valid", ConsoleColor.Red);
            }


        }

        private int[,] CollectSudokukoData()
        {
            int[,] data = new int[9, 9];
            bool escapeWhileLoop = false;

            for(int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write($"Enter Matrix[{row + 1}][{col + 1}]: ");
                    do
                    {
                        string stringDate = Console.ReadLine();
                        if (int.TryParse(stringDate, out int value))
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
