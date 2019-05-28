using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Circle
    {
        public enum Direction
        {
            left, right, up, down
        }

        public Color color { get; set; }
        public Point point { get; set; }
        public int Radius { get; set; }
        public Direction direction { get; set; } 
        public Boolean moving { get; set; }

        public Circle(Point p, Color color)
        {
            this.point = p;
            this.color = color;
            this.Radius = 30;
            RandomDirection();
            moving = false;
        }

        public void RandomDirection()
        {
            Random random = new Random();
            this.direction = Direction.left;
            int dir = random.Next(0, 4);
            if (dir == 1)
                this.direction = Direction.right;
            else if (dir == 2)
                this.direction = Direction.up;
            else if (dir == 3)
                this.direction = Direction.down;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(color);

            g.FillEllipse(b, point.X-Radius, point.Y-Radius, Radius*2, Radius*2);

            b.Dispose();
        }

        public void Move()
        {
            if (!moving)
                return;
            if(this.direction == Direction.left)
            {
                this.point = new Point(point.X-10, point.Y);
            }
            else if(this.direction == Direction.right)
            {
                this.point = new Point(point.X + 10, point.Y);
            }
            else if(this.direction == Direction.up)
            {
                this.point = new Point(point.X, point.Y-10);
            }
            else if(this.direction == Direction.down)
            {
                this.point = new Point(point.X, point.Y + 10);
            }
        }

        public Boolean IsClicked(Point p)
        {
            return (p.X - point.X) * (p.X - point.X) + (p.Y - point.Y) * (p.Y - point.Y) <= Radius * Radius;
        }

        public Boolean Touching(Circle c)
        {
            return (c.point.X - point.X) * (c.point.X - point.X) + (c.point.Y - point.Y) * (c.point.Y - point.Y) <= Radius * Radius;
        }
    }
}
