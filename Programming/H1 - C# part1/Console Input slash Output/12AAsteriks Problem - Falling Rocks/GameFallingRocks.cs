/*GameFallingRocks*/
/*
 * Problem 12.** Falling Rocks

    Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;


namespace Game
{

    struct Position
    {
       
        public int row;
        public int col;
      
        public Position(int row, int col) 
        {
            this.row = row;
            this.col = col;
        }
         
    }

    class GameFallingRocks
    {
        static void Main()
        {
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;

            Position[] directions = new Position[]
            {
                new Position(0, 1),     //right
                new Position(0, -1),    //left
                new Position(1, 0),     //down
                new Position(-1, 0)     //up
            };
            int sleepTime = 100;
            int direction = right;  
            Random randomNumbersGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Position food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                randomNumbersGenerator.Next(0, Console.WindowWidth));
            

            Queue<Position> snakeElements = new Queue<Position>();

 /*
            Position position1 = new Position(0,0);
            position1.X = 0;
            position1.Y = 0; */

            for (int i = 0; i < 7; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }
           

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = left;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        direction = right;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        direction = up;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        direction = down;
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
                            snakeHead.col + nextDirection.col);

                if (snakeNewHead.row < 0 ||
                    snakeNewHead.col < 0 ||
                    snakeNewHead.row >= Console.WindowHeight ||
                    snakeNewHead.col >= Console.WindowWidth)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!");
                }

                snakeElements.Enqueue(snakeNewHead);
                if ((snakeNewHead.col == food.col) && (snakeNewHead.row == food.row))
                { 
                    //feeding
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                        randomNumbersGenerator.Next(0, Console.WindowWidth));
                }
                else
                {
                    //moving...
                    snakeElements.Dequeue();
                }

                Console.Clear();
                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.Write("*");
                }

                

                Console.SetCursorPosition(food.row, food.col);
                Console.Write("@");

                Thread.Sleep(sleepTime);

            }
        }
    }
}