using System;

namespace text_gamething_v3
{
    class Game
    {
        public class Tiles : Game
        {
            int xPos;
            int yPos;
            bool collision;
            string tile;

            public string GetTile
            {
                get
                {
                    return tile;
                }
            }
            public bool GetCollision
            {
                get
                {
                    return collision;
                }
            }
            public int GetXPos
            {
                get
                {
                    return xPos;
                }
            }
            public int GetYPos
            {
                get
                {
                    return yPos;
                }
            }
            public void OnCollide()
            {

            }
            public class Player : Tiles
            {
                public Player(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "@";
                    collision = true;
                }
                public void MoveUp(int x, int y, Tiles[, ] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    yPos = y - 1;
                    board[player.GetXPos, player.GetYPos] = player;
                    
                }
                public void MoveDown(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    yPos = y + 1;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void MoveRight(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    xPos = x + 1;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void MoveLeft(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    xPos = x - 1;
                    board[player.GetXPos, player.GetYPos] = player;
                }
            }

            public class Floor : Tiles
            {
                public Floor(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = ".";
                    collision = false;
                }
            }

            public class Wall : Tiles
            {
                public Wall(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "#";
                    collision = true;
                }
            }
            public class Door : Tiles
            {
                public Door(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "!";
                    collision = false;
                }
            }
        }
    }
}