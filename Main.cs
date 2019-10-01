using System;

//new programmer, dont make fun of me if you're reading this. not quite sure what im doing tbh
namespace text_gamething_v3
{
    class ExecuteGame : Game
    {
        public Tiles.Player player;
        public Tiles[,] board;
        public Tiles.Enemy enemy;

        private static void Main()
        {
            ExecuteGame game = new ExecuteGame();
            game.PlayGame();
        }
        //starts game
        public void PlayGame()
        {
            CreateRoom(5, 5);
        }
        //fills board with Tiles.Floor objects  
        private void CreateRoom(int playerSpawnX, int playerSpawnY)
        {
            board = new Tiles[10, 10];

            int x = 0;
            int y = 0;

            //fills board with floor

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
            x = 0;
            y = 0;
            // spawns walls
            for (int i = 0; i < 10; i++)
            {
                board[x, y] = new Tiles.Wall(x, y);
                x++;
            }
            x = 9;
            y = 9;
            for (int i = 0; i < 10; i++)
            {
                board[x, y] = new Tiles.Wall(x, y);
                x--;
            }
            x = 9;
            for (int i = 0; i < 10; i++)
            {
                board[x, y] = new Tiles.Wall(x, y);
                y--;
            }
            x = 0;
            y = 0;
            for (int i = 0; i < 10; i++)
            {
                board[x, y] = new Tiles.Wall(x, y);
                y++;
            }
            // spawns random doors on edges where walls are
            Random random = new Random();
            int initialRandom = 4;
            //int initialRandom = random.Next(1, 4);

            int randomNumber1 = random.Next(3, 7);
            int randomNumber2 = random.Next(3, 7);
            int randomNumber3 = random.Next(3, 7);
            int randomNumber4 = random.Next(3, 7);

            // 
            switch (initialRandom)
            {
                case 1:
                    board[0, randomNumber1] = new Tiles.Door(0, randomNumber1);
                    break;

                case 2:
                    board[0, randomNumber1] = new Tiles.Door(0, randomNumber1);
                    board[9, randomNumber2] = new Tiles.Door(9, randomNumber2);
                    break;

                case 3:
                    board[0, randomNumber1] = new Tiles.Door(0, randomNumber1);
                    board[9, randomNumber2] = new Tiles.Door(9, randomNumber2);
                    board[randomNumber3, 0] = new Tiles.Door(randomNumber3, 0);
                    break;

                case 4:
                    board[0, randomNumber1] = new Tiles.Door(0, randomNumber1);
                    board[9, randomNumber2] = new Tiles.Door(9, randomNumber2);
                    board[randomNumber3, 0] = new Tiles.Door(randomNumber3, 0);
                    board[randomNumber4, 9] = new Tiles.Door(randomNumber4, 9);
                    break;
            }
            enemy = new Tiles.Enemy(2, 2);
            board[2, 2] = enemy;
            //spawns player
            SpawnPlayer(playerSpawnX, playerSpawnY);
            
        }

        //creates Tiles.Player at coords of X and Y
        private void SpawnPlayer(int x, int y)
        {
            board[x, y] = null;
            player = new Tiles.Player(x, y);
            board[x, y] = player;
            DisplayRoom();
        }
        //clears cmd prompt, then displays each line of board
        private void DisplayRoom()
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
            Console.WriteLine("Controls: wasd to move");
            UserInput();
        }
        //takes user input, clears tile that player is on, puts Tile.Floor there, then puts Player into the tile they want to move to.
        private void UserInput()
        {
            var userInput = Console.ReadKey();
            enemy.FindPlayer(board, player, enemy);

            if (userInput.Key == ConsoleKey.W)
            {
                //switch to decide what to do when colliding with objects. Collision types in Tiles.cs
                switch (board [player.GetXPos, player.GetYPos - 1].GetCollisionType)
                {
                    case 0:
                        player.MoveUp(player.GetXPos, player.GetYPos, board, player);
                        DisplayRoom();
                        break;

                    case 1:
                        DisplayRoom();
                        break;

                    case 2:
                        int playerX = player.GetXPos;
                        int playerY = 8;
                        CreateRoom(playerX, playerY);
                        break;
                }
            }
            else if (userInput.Key == ConsoleKey.A)
            {
                switch (board [player.GetXPos - 1, player.GetYPos].GetCollisionType)
                {
                    case 0:
                        player.MoveLeft(player.GetXPos, player.GetYPos, board, player);
                        DisplayRoom();
                        break;

                    case 1:
                        DisplayRoom();
                        break;

                    case 2:
                        int playerX = 8;
                        int playerY = player.GetYPos;
                        CreateRoom(playerX, playerY);
                        break;
                }
            }
            else if (userInput.Key == ConsoleKey.S)
            {
                switch (board[player.GetXPos, player.GetYPos + 1].GetCollisionType)
                {
                    case 0:
                        player.MoveDown(player.GetXPos, player.GetYPos, board, player);
                        DisplayRoom();
                        break;

                    case 1:
                        DisplayRoom();
                        break;

                    case 2:
                        int playerX = player.GetXPos;
                        int playerY = 1;
                        CreateRoom(playerX, playerY);
                        break;
                }
            }
            else if (userInput.Key == ConsoleKey.D)
            {
                switch (board[player.GetXPos + 1, player.GetYPos].GetCollisionType)
                {
                    case 0:
                        player.MoveRight(player.GetXPos, player.GetYPos, board, player);
                        DisplayRoom();
                        break;

                    case 1:
                        DisplayRoom();
                        break;

                    case 2:
                        int playerX = 1;
                        int playerY = player.GetYPos;
                        CreateRoom(playerX, playerY);
                        break;
                }
            }
        }
    }
}
