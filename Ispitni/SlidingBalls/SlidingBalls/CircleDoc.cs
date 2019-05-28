using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> circles { get; set; }
        public Boolean ongoingBallMove { get; set; }
        public CircleDoc()
        {
            circles = new List<Circle>();
            ongoingBallMove = false;
        }

        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void Move(int h, int w)
        {
            for(int i = 0; i < circles.Count; i++)
            {      
                Circle c = circles[i];
                if (c.color != Color.Red)
                    continue;
                c.Move();
                if (c.point.X - (c.Radius) <= 0 || c.point.X + (c.Radius) >= w 
                    || c.point.Y - (c.Radius) <= 0 || c.point.Y + (c.Radius) >= h)
                {
                    circles.RemoveAt(i);
                    ongoingBallMove = false;
                    continue;
                }
                 
                for(int j = 0; j < circles.Count; j++)
                {
                    if (circles[j].color == Color.Green && c.Touching(circles[j]))
                        circles.RemoveAt(j);
                }
            }
        }

        public Boolean Click(Point p)
        {
            if (ongoingBallMove)
                return false;
            foreach (Circle c in circles)
            {
                if (c.color == Color.Red && c.IsClicked(p))
                {
                    c.moving = true;
                    ongoingBallMove = true;
                    return true;
                }
            }
            return false;
        }
    }
}
