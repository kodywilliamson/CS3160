using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Game
    {
        Graphics g;
        private int whoTurn;
        private Shape[,] grid;
        private Coordinates[,] coord;

        public int Moves { set; get; }
        public bool isGameOver()
        {
            if (Moves == 9)
                return true;
            else
                return false;
        }
        private bool isWin()
        {

        }
        public string nextMove(int x, int y)
        {
            if (whoTurn )
        }
        private void resetGrid()
        {

        }
    }
    abstract class Shape
    {
        public static Graphics g;
        public abstract void Draw(int x1, int y1, int x2, int y2);
    }
    class Ex : Shape
    {
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            g.DrawLine(Pens.Black, x1, y2, x2, y1);
        }
    }
    class Oh : Shape
    {
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            g.DrawEllipse(Pens.Black, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }
    }
}
