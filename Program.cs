using SudokuValidator;

internal class Program
{
    private static void Main(string[] args)
    {
        string closeGameOption = "";

        while (closeGameOption != "q" && closeGameOption != "Q")
        {
            SudokuGame Game = new SudokuGame() { Name = "My Sudoku Game" };
            Game.Start();


            Console.WriteLine("Enter q or Q to quit game or press any other key to continue!");
            closeGameOption = Console.ReadLine();
            
        }
    }
}