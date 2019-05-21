using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    [Serializable]
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Color color { get; set; }
        public Boolean movingDown { get; set; }
        public Boolean movingRight { get; set; }

        public Rectangle(int x, int y, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Width = 100;
            this.Height = 50;
            this.color = color;
            this.movingDown = false;
            this.movingRight = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.color);
            g.FillRectangle(b, X, Y, this.Width, this.Height);
            b.Dispose();
        }

        public void Move()
        {
            if (movingDown)
            {
                this.Y += this.Height;
            }
            else if (movingRight)
            {
                this.X += 50;
                int tmp = this.Width;
                this.Width = this.Height;
                this.Height = tmp;
            }
        }

        public Boolean IsClicked(Point p)
        {
            Boolean xRange = (p.X > this.X && p.X < this.X + this.Width);
            Boolean yRange = (p.Y > this.Y && p.Y < this.Y + this.Height);
            bool toRet = xRange && yRange;
            return toRet;
        }
    }
}
