namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
            public class Sword : Tiles
            {
                //sword needs to have a collision type that destroys enemies but not walls and floor 
                public Sword(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "/";
                }
            }
        }
    }
}
