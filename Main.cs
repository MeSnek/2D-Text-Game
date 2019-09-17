using System;
using System.Collections.Generic;
using System.Text;

namespace text_gamething_v3
{
    class ExecuteGame : Game
    {
        public Tiles.Player player;
        public Tiles[,] board;

        private static void Main(String[] args)
        {
            ExecuteGame game = new ExecuteGame();
            game.PlayGame();
        }

        public void PlayGame()
        {
            PopulateBoard();
        }
        private void PopulateBoard()
        {
            board = new Tiles[10, 10];

            int x = 0;
            int y = 0;

            for (int i = 0; i < 11; i++)
            {
                if (x == 10)
                {
                    x = 0;
                    y++;
                    i = 0;
                    if (y == 10)
                    {
                        break;
                    }
                }
                board[x, y] = new Tiles.Floor(x, y);
                x++;
            }
            SpawnPlayer(5, 5);
        }
        private void SpawnPlayer(int x, int y)
        {
            board[x, x] = null;
            player = new Tiles.Player(x, y);
            board[x, y] = player;
            DisplayBoard();
        }
        private void DisplayBoard()
        {
            Console.Clear();
            int x = 0;
            int y = 0;
            const string newLine = "\r";

            for (int i = 0; i < 11; i++)
            {
                if (x == 10)
                {
                    x = 0;
                    y++;
                    i = 0;
                    Console.WriteLine(newLine);

                    if (y == 10)
                    {
                        break;
                    }
                }
                Console.Write(board[x, y].GetTile);
                x++;
            }
            string userInput = Console.ReadLine();
            UserInput(userInput);
        }
        //todo: make outside bounds not moveable so no array error
        private void UserInput(string userInput)
        {
            if (userInput == "w" || userInput == "W")
            {
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveUp(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = player;
                DisplayBoard();
            }
            else if (userInput == "a" || userInput == "A")
            {
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveLeft(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = player;
                DisplayBoard();
            }
            else if (userInput == "s" || userInput == "S")
            {
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveDown(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = player;
                DisplayBoard();
            }
            else if (userInput == "d" || userInput == "D")
            {
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveRight(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = null;
                board[player.GetXPos, player.GetYPos] = player;
                DisplayBoard();
            }
        }
    }
}
