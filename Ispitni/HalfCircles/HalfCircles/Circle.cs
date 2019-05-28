using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{   [Serializable]
    public class Circle
    {
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int tmpX { get; set; }
        public int tmpY { get; set; }
        public float Radius { get; set; }

        public Circle (int x, int y, Color color)
        {
            this.X = x;
            this.Y = y;
            this.tmpX = X;
            this.tmpY = Y;
            this.PrimaryColor = color;
            this.Radius = 30;
            this.SecondaryColor = color;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.PrimaryColor);
            g.FillEllipse(b, tmpX, tmpY, Radius * 2, Radius * 2);
            b.Dispose();
        }

        public void Pulse()
        {
            this.Radius += 3;
            tmpX -= 3;
            tmpY -= 3;
            if (Radius >= 60)
            {
                Radius = 30;
                tmpX = X;
                tmpY = Y;
            }
                
        }
    }
}
