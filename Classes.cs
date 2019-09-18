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
            public class Player : Tiles
            {
                public Player(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "@";
                    collision = true;
                }
                //todo: make check for collision, and not do move if collision true
                public void MoveUp(int x, int y)
                {
                    yPos = y - 1;
                }
                public void MoveDown(int x, int y)
                {
                    yPos = y + 1;
                }
                public void MoveRight(int x, int y)
                {
                    xPos = x + 1;
                }
                public void MoveLeft(int x, int y)
                {
                    xPos = x - 1;
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
        }
    }
}