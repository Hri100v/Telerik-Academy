using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesweeperGame
{
    public class MineSweeper
	{
		public class Points
		{
			string name;
			int pointsAmount;

			public Points() { }

            public Points(string name, int points)
			{
                this.Name = name;
                this.PointsAmount = points;
			}
			
            public string Name
			{
				get { return name; }
				private set { name = value; }
			}

			public int PointsAmount
			{
				get { return pointsAmount; }
				private set { pointsAmount = value; }
			}

		}

		static void Main(string[] arguments)
		{
			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombsPosition = CreateBombs();
			int countMoves = 0;
			bool fire = false;
			List<Points> rankList = new List<Points>(6);
			int row = 0;
			int col = 0;
			bool flagStartGame = true;
			const int NumberOfMines = 35;
			bool flag2FinishGame = false;

			do
			{
				if (flagStartGame)
				{
					Console.WriteLine("Let's play \"Minesweeper\". Try Your chance to move only on fields without mines!" +
                    "Command 'top' show rating, 'restart' start new game, 'exit' out of the game!");
					dumpp(field);
					flagStartGame = false;
				}
				Console.Write("Give row & col : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= field.GetLength(0) && col <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						CreateRankList(rankList);
						break;
					case "restart":
                        field = CreateGameField();
						bombsPosition = CreateBombs();
						dumpp(field);
						fire = false;
						flagStartGame = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombsPosition[row, col] != '*')
						{
							if (bombsPosition[row, col] == '-')
							{
								MakeMove(field, bombsPosition, row, col);
								countMoves++;
							}
							if (NumberOfMines == countMoves)
							{
								flag2FinishGame = true;
							}
							else
							{
								dumpp(field);
							}
						}
						else
						{
							fire = true;
						}
						break;
					default:
						Console.WriteLine("\nWrong! Invalid command!\n");
						break;
				}
				if (fire)
				{
					dumpp(bombsPosition);
					Console.Write("\nSorry! You lost this game with {0} points." +
                        "Give your nickname: ", countMoves);
					string playerNickname = Console.ReadLine();
					Points playerPoints = new Points(playerNickname, countMoves);
					if (rankList.Count < 5)
					{
						rankList.Add(playerPoints);
					}
					else
					{
						for (int i = 0; i < rankList.Count; i++)
						{
                            if (rankList[i].PointsAmount < playerPoints.PointsAmount)
							{
								rankList.Insert(i, playerPoints);
								rankList.RemoveAt(rankList.Count - 1);
								break;
							}
						}
					}
					rankList.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    rankList.Sort((Points r1, Points r2) => r2.PointsAmount.CompareTo(r1.PointsAmount));
					CreateRankList(rankList);

                    field = CreateGameField();
					bombsPosition = CreateBombs();
					countMoves = 0;
					fire = false;
					flagStartGame = true;
				}
				if (flag2FinishGame)
				{
                    Console.WriteLine("\nCONGRATULATIONS! Found {0} bombs, without wrong steps.", NumberOfMines);
					dumpp(bombsPosition);
                    Console.WriteLine("Give your nickname: ");
					string playerNickname = Console.ReadLine();
					Points points = new Points(playerNickname, countMoves);
					rankList.Add(points);
					CreateRankList(rankList);
                    field = CreateGameField();
					bombsPosition = CreateBombs();
					countMoves = 0;
					flag2FinishGame = false;
					flagStartGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria!");
			Console.WriteLine("I think we see you soon.");
			Console.Read();
		}

		private static void CreateRankList(List<Points> playerList)
		{
			Console.WriteLine("\nPOITS:");
			if (playerList.Count > 0)
			{
				for (int i = 0; i < playerList.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} score",
						i + 1, playerList[i].Name, playerList[i].PointsAmount);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty rating!\n");
			}
		}

		private static void MakeMove(char[,] Field,
			char[,] bombsPosition, int row, int col)
		{
			char numberOfBombs = CountNearBombs(bombsPosition, row, col);
			bombsPosition[row, col] = numberOfBombs;
			Field[row, col] = numberOfBombs;
		}

		private static void dumpp(char[,] board)
		{
			int bordRows = board.GetLength(0);
			int bordCols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < bordRows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < bordCols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

        private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] CreateBombs()
		{
			int rows = 5;
			int cols = 10;
			char[,] gameField = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> listRandomNumbers = new List<int>();
			while (listRandomNumbers.Count < 15)
			{
				Random random = new Random();
				int randNum = random.Next(50);
				if (!listRandomNumbers.Contains(randNum))
				{
					listRandomNumbers.Add(randNum);
				}
			}

			foreach (int number in listRandomNumbers)
			{
				int col = (number / cols);
				int row = (number % cols);
				if (row == 0 && number != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				gameField[col, row - 1] = '*';
			}

			return gameField;
		}

		private static void Calculations(char[,] field)
		{
			int col = field.GetLength(0);
			int row = field.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (field[i, j] != '*')
					{
						char numberOfBombs = CountNearBombs(field, i, j);
						field[i, j] = numberOfBombs;
					}
				}
			}
		}

        private static char CountNearBombs(char[,] currentField, int bordRows, int bordCols)
		{
			int counter = 0;
			int rows = currentField.GetLength(0);
			int cols = currentField.GetLength(1);

			if (bordRows - 1 >= 0)
			{
				if (currentField[bordRows - 1, bordCols] == '*')
				{ 
					counter++; 
				}
			}
			if (bordRows + 1 < rows)
			{
				if (currentField[bordRows + 1, bordCols] == '*')
				{ 
					counter++; 
				}
			}
			if (bordCols - 1 >= 0)
			{
				if (currentField[bordRows, bordCols - 1] == '*')
				{ 
					counter++;
				}
			}
			if (bordCols + 1 < cols)
			{
				if (currentField[bordRows, bordCols + 1] == '*')
				{ 
					counter++;
				}
			}
			if ((bordRows - 1 >= 0) && (bordCols - 1 >= 0))
			{
				if (currentField[bordRows - 1, bordCols - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((bordRows - 1 >= 0) && (bordCols + 1 < cols))
			{
				if (currentField[bordRows - 1, bordCols + 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((bordRows + 1 < rows) && (bordCols - 1 >= 0))
			{
				if (currentField[bordRows + 1, bordCols - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((bordRows + 1 < rows) && (bordCols + 1 < cols))
			{
				if (currentField[bordRows + 1, bordCols + 1] == '*')
				{ 
					counter++; 
				}
			}
			return char.Parse(counter.ToString());
		}
	}
}
