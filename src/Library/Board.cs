using System;

namespace PII_Game_Of_Life
{
    public class board
    {
        bool[,] board;
        int boardWidth {get; set;}
        int boardHeigth {get; set;}
        public Board(int width, int height, bool[,] board)
        {
            this.boardWidth = width;
            this.boardHeigth = height;
            this.board = new bool[width, height];

        }
    }
}
