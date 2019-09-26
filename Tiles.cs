using System;

namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles : Game
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
        }
    }
}