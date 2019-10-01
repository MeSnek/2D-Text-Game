using System;

namespace text_gamething_v3
{
    partial class Game
    {
        public partial class Tiles
        {
            public class Enemy : Tiles
            {
                public Enemy(int x, int y)
                {
                    xPos = x;
                    yPos = y;
                    tile = "X";
                    searchDistance = 2;
                }
                public void FindPlayer(Tiles [, ]board, Player player, Enemy enemy)
                {
                    double enemyXPos = enemy.GetXPos;
                    double enemyYPos = enemy.GetYPos;
                    double playerXPos = player.GetXPos;
                    double playerYPos = player.GetYPos;

                    //find distance between two points algorithm 
                    //D = √( (x1 - x2)^2 + (y1 - y2)^2 )
                    double distance = Math.Sqrt( Math.Pow( (enemyXPos - playerXPos), 2) + Math.Pow( (enemyYPos - playerYPos) , 2) );

                    if (distance <= enemy.GetSearchDistance)
                    {
                        //looks up and down first
                        //up
                        if (playerYPos < enemyYPos)
                        {
                            if (enemyXPos < playerXPos && distance < 2)
                            {
                                enemy.MoveRight(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                            else if (enemyXPos > playerXPos && distance < 2)
                            {
                                enemy.MoveLeft(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                            else
                            {
                                enemy.MoveUp(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                        }
                        //down
                        else if (playerYPos > enemyYPos)
                        {
                            if (enemyXPos < playerXPos && distance < 2)
                            {
                                enemy.MoveRight(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                            else if (enemyXPos > playerXPos && distance < 2)
                            {
                                enemy.MoveLeft(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                            else
                            {
                                enemy.MoveDown(enemy.GetXPos, enemy.GetYPos, board, enemy);
                            }
                        }

                    }
                }
                public void MoveUp(int x, int y, Tiles[,] board, Enemy enemy)
                {
                    board[enemy.GetXPos, enemy.GetYPos] = new Tiles.Floor(enemy.GetXPos, enemy.GetYPos);
                    yPos = y - 1;
                    board[enemy.GetXPos, enemy.GetYPos] = enemy;
                }
                public void MoveDown(int x, int y, Tiles[,] board, Enemy enemy)
                {
                    board[enemy.GetXPos, enemy.GetYPos] = new Tiles.Floor(enemy.GetXPos, enemy.GetYPos);
                    yPos = y + 1;
                    board[enemy.GetXPos, enemy.GetYPos] = enemy;
                }
                public void MoveRight(int x, int y, Tiles[,] board, Enemy enemy)
                {
                    board[enemy.GetXPos, enemy.GetYPos] = new Tiles.Floor(enemy.GetXPos, enemy.GetYPos);
                    xPos = x + 1;
                    board[enemy.GetXPos, enemy.GetYPos] = enemy;
                }
                public void MoveLeft(int x, int y, Tiles[,] board, Enemy enemy)
                {
                    board[enemy.GetXPos, enemy.GetYPos] = new Tiles.Floor(enemy.GetXPos, enemy.GetYPos);
                    xPos = x - 1;
                    board[enemy.GetXPos, enemy.GetYPos] = enemy;
                }
            }
        }
    }
}