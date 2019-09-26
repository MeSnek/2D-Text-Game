namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
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