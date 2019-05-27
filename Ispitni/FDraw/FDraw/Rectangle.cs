using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Color color { get; set; }

        public Rectangle(int width, int height, int x, int y, Color color)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, this.x, this.y, this.width, this.height);
        }

        public Boolean isClicked(Point p)
        {
            return (p.X > x && p.X < x + width) && (p.Y > y && p.Y < y + height);
        }

        public void Move(Point p)
        {
            x = p.X;
            y = p.Y;
        }
    }
}
