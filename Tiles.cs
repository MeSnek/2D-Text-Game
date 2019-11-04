using System;

namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles : Game
        {
            //Collision types: 
            //0 = no collision, movement happens
            //1 = full collision, no movement
            //2 = door collision, move to a new room
            //todo: 3 = items or something 
            int collisionType;
            
            int xPos;
            int yPos;
            int searchDistance;
            
            //Directions:
            //0 = up
            //1 = right
            //2 = down
            //3 = left
            int playerDirection;
            
            string tile;

            public string GetTile
            {
                get { return tile; }
            }
            public int GetCollisionType
            {
                get { return collisionType; }
            }
            public int GetXPos
            {
                get { return xPos; }
            }
            public int GetYPos
            {
                get { return yPos; }
            }
            public int GetSearchDistance
            {
                get { return searchDistance; }
            }
        }
    }
}