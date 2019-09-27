using System;

namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles : Game
        {
            int xPos;
            int yPos;
            //Collision types: 
            //0 = no collision, movement happens
            //1 = full collision, no movement
            //2 = door collision, move to a new room
            //todo: 3 = items or something 
            int collisionType;
            string tile;

            public string GetTile
            {
                get
                {
                    return tile;
                }
            }
            public int GetCollisionType
            {
                get
                {
                    return collisionType;
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