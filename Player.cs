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
        }
    }
}