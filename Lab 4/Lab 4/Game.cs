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
        private int numTurn;
        private Shape[,] grid;
        private Coordinates[,] coord;

        public bool isGameOver()
        {
            
        }
        private bool isWin()
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
