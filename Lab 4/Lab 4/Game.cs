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
        public Game()
        {
            coord = new Coordinates[3, 3];
            coord[0, 0] = new Coordinates(40, 70, 100, 130);
            coord[0, 1] = new Coordinates(100, 70, 160, 130);
            coord[0, 2] = new Coordinates(160, 70, 220, 130);
            coord[1, 0] = new Coordinates(40, 130, 100, 190);
            coord[1, 1] = new Coordinates(100, 130, 160, 190);
            coord[1, 2] = new Coordinates(160, 130, 220, 190);
            coord[2, 0] = new Coordinates(40, 190, 100, 250);
            coord[2, 1] = new Coordinates(100, 190, 160, 250);
            coord[2, 2] = new Coordinates(160, 190, 220, 250);
            grid = new Shape[3, 3];
        }
        public bool isGameOver()
        {
            if (Moves == 9)
                return true;
            else
                return false;
        }
        private bool isWin()
        {
            if (grid[0, 0] == grid[0,1] && grid[0, 1] == grid[0,2])
            {
                return true;
            }
            if (grid[1, 0] == grid[1,1] && grid[1, 1] == grid[1,2])
            {
                return true;
            }
            if (grid[2, 0] == grid[2,1] && grid[2, 1] == grid[2, 2])
            {
                return true;
            }
            if (grid[0, 0] == grid[1,0] && grid[1, 0] == grid[2, 0])
            {
                return true;
            }
            if (grid[0, 1] == grid[1,1] && grid[1, 1] == grid[2, 1])
            {
                return true;
            }
            if (grid[0, 2] == grid[1,2] && grid[1, 2] == grid[2, 2])
            {
                return true;
            }
            if (grid[0, 0] == grid[1,1] && grid[1, 1] == grid[2, 2])
            {
                return true;
            }
            if (grid[0, 2] == grid[1,1] && grid[1, 1] == grid[2, 0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string nextMove(int x, int y)
        {
            Point test = new Point(x, y);
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Rectangle myR = new Rectangle(coord[j, i].x1, coord[j, i].y1, Math.Abs(coord[j, i].x2 - coord[j, i].x1), Math.Abs(coord[j, i].y2 - coord[j, i].y1));
                    if (myR.Contains(test))
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            if (isFilled(x, y))
            {
                return "Square in use, try again";
            }
            Moves++;
            whoTurn = Moves % 2;
            if (whoTurn == 0)
            {
                grid[x, y] = new Oh();
                grid[x, y].Draw(coord[x, y].x1, coord[x, y].y1, coord[x, y].x2, coord[x, y].y2);
                return "X's Turn";
            }
            else
            {
                grid[x, y] = new Ex();
                grid[x, y].Draw(coord[x, y].x1, coord[x, y].y1, coord[x, y].x2, coord[x, y].y2);
                return "O's Turn";
            }

                
        }
        private void resetGrid()
        {

        }
        private bool isFilled(int x, int y)
        {
            if (grid[x, y] is Shape)
                return true;
            return false;
        }
    }
    public abstract class Shape
    {
        public static Graphics g;
        public abstract void Draw(int x1, int y1, int x2, int y2);
    }
    public class Ex : Shape
    {
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
            g.DrawLine(Pens.Black, x1, y2, x2, y1);
        }
    }
    public class Oh : Shape
    {
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            g.DrawEllipse(Pens.Black, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }
    }
    public class Coordinates
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public Coordinates(int a, int b, int c, int d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
    }
}
