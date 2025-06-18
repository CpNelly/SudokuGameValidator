
# 🧩 Sudoku Validator in C#

This is a simple **Sudoku Validator** built with **C# and .NET**, designed to validate a completed 9x9 Sudoku grid. It checks whether the grid satisfies all Sudoku rules:

- ✅ Each **row** contains digits 1–9 without repetition.
- ✅ Each **column** contains digits 1–9 without repetition.
- ✅ Each **3x3 subgrid** contains digits 1–9 without repetition.

It also neatly prints the Sudoku grid in a formatted console output.

---

## 🚀 How to Run the App

### 📦 Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or later
- Option 1: **Visual Studio 2022** (recommended for full C# development)
- Option 2: **Visual Studio Code** with the **C# Dev Kit** or **C# Extension**

---

### 🔧 Option 1: Run with Visual Studio 2022

1. **Clone the repository**
   ```bash
   git clone https://github.com/CpNelly/SudokuGameValidator.git
   cd SudokuGameValidator

	2.	Open in Visual Studio 2022
	•	Go to File > Open > Project/Solution
	•	Select the .csproj or .sln file inside the project folder
	3.	Build and Run
	•	Press Ctrl + F5 (Start Without Debugging)
	•	You’ll see the printed Sudoku board and the validation result when you select the first option when you open the console app

🔧 Option 2: Run with Visual Studio Code

	1.	Install Extensions in VS Code
	•	Open Extensions (Ctrl+Shift+X)
	•	Install:
	•	C# Dev Kit (or C# for Visual Studio Code powered by OmniSharp)
	•	.NET Install Tool for Extension Authors
	2.	Open the project

cd SudokuGameValidator
code .


	3.	Run the app
	•	Open a terminal in VS Code (Ctrl + )
	•	Run:

dotnet run

🧪 Sample Output

	 | 5 3 4 | 6 7 8 | 9 1 2 |
	 | 6 7 2 | 1 9 5 | 3 4 8 |
	 | 1 9 8 | 3 4 2 | 5 6 7 |
	 --------+-------+--------
	 | 8 5 9 | 7 6 1 | 4 2 3 |
	 | 4 2 6 | 8 5 3 | 7 9 1 |
	 | 7 1 3 | 9 2 4 | 8 5 6 |
	 --------+-------+--------
	 | 9 6 1 | 5 3 7 | 2 8 4 |
	 | 2 8 7 | 4 1 9 | 6 3 5 |
	 | 3 4 5 | 2 8 6 | 1 7 9 |
	
	 

✅ The Sudoku solution is valid.

📁 Project Structure

	SudokuValidator/
	├── Program.cs        
	├── SudokuValidator.cs
	├── SudokuGame  
	├── README.md         
	└── .gitignore         

🛠️ Technologies Used

	•	C#
	•	.NET Console App
	•	Visual Studio 2022
 

🙋 Author

	Created by [Neba Nelly]
	GitHub: @CpNelly
	Email: Nebanelly3@gmail.com
