using System;
using System.Collections.Generic;
using System.Text;

//new programmer, dont make fun of me if you're reading this. not quite sure what im doing tbh
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
        //fills board with Tiles.Floor objects
        //todo: make thing to create walls around outside of board
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
        //creates Tiles.Player at coords of X and Y
        private void SpawnPlayer(int x, int y)
        {
            board[x, y] = null;
            player = new Tiles.Player(x, y);
            board[x, y] = player;
            DisplayBoard();
        }
        //clears cmd prompt, then displays each line of board
        private void DisplayBoard()
        {
            board[1, 1] = new Tiles.Wall(1,1);
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
            Console.WriteLine("Controls: wasd to move, one letter at a time, no capital letters");
            string userInput = Console.ReadLine();
            UserInput(userInput);
        }
        //takes user input, clears tile that player is on, puts Tile.Floor there, then puts Player into the tile they want to move to.
        //todo: make outside bounds not moveable so no array error
        private void UserInput(string userInput)
        {
            if (userInput == "w" && !board [player.GetXPos, player.GetYPos - 1].GetCollision)
            {
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveUp(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = player;

                DisplayBoard();
            }
            else if (userInput == "a" && !board[player.GetXPos - 1, player.GetYPos].GetCollision)
            {
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveLeft(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = player;

                DisplayBoard();
            }
            else if (userInput == "s" && !board[player.GetXPos, player.GetYPos + 1].GetCollision)
            {
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveDown(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = player;

                DisplayBoard();
            }
            else if (userInput == "d" && !board[player.GetXPos + 1, player.GetYPos].GetCollision)
            {
                board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                player.MoveRight(player.GetXPos, player.GetYPos);
                board[player.GetXPos, player.GetYPos] = player;

                DisplayBoard();
            }
            //gets called if collision is true
            DisplayBoard();
        }
    }
}
