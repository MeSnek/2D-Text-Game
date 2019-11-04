namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
            public class Player : Tiles
            {
                public Player(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "@";

                    //0 = up
                    //1 = down
                    //2 = right
                    //3 = left
                    playerDirection = 0;
                }
                public void MoveUp(int x, int y, Tiles[, ] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    yPos = y - 1;
                    playerDirection = 0;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void MoveDown(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    yPos = y + 1;
                    playerDirection = 1;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void MoveRight(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    xPos = x + 1;
                    playerDirection = 2;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void MoveLeft(int x, int y, Tiles[,] board, Player player)
                {
                    board[player.GetXPos, player.GetYPos] = new Tiles.Floor(player.GetXPos, player.GetYPos);
                    xPos = x - 1;
                    playerDirection = 3;
                    board[player.GetXPos, player.GetYPos] = player;
                }
                public void SwingSword(Tiles[, ] board, Player player)
                {
                    switch (playerDirection)
                    {
                        case 0:

                        case 1:

                        case 2:

                        case 3:
                    }
                }
            }
        }
    }
}