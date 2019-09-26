namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
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
        }
    }
}