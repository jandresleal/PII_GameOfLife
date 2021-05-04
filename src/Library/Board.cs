using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        bool[,] board;
        public int BoardWidth {get; set;}
        public int BoardHeigth {get; set;}
        public Board(int width, int height, bool[,] board)
        {
            this.BoardWidth = width;
            this.BoardHeigth = height;
            this.board = new bool[width, height];
            for (int x = 0; x <= width; x++)
                {
                    for (int y = 0; y <= height; y++)
                    {
                        this.board[x,y] = board[x,y];
                    }
                }

        }
        public void SetCell(int x, int y, bool viva)
        {
            this.board[x,y] = viva;
        }
         public bool GetCell(int x, int y)
        {
            return this.board[x,y];
        }
    }
}
