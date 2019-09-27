namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
            public class Wall : Tiles
            {
                public Wall(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "#";
                    collisionType = 1;
                }
            }
        }
    }
}