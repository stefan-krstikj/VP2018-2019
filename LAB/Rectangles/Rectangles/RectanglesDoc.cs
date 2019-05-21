using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangles
{
    [Serializable]
    public class RectanglesDoc
    {
        public List<Rectangle> rectangles { get; set; }


        public RectanglesDoc()
        {
            this.rectangles = new List<Rectangle>();
        }

        public void Draw(Graphics g)
        {
            foreach(Rectangle rec in rectangles)
            {
                rec.Draw(g);
            }
        }

        public void Move(int maxW, int maxH)
        {
            for (int i = 0; i < rectangles.Count; i++)
            {
                rectangles[i].Move();
                if (rectangles[i].X + rectangles[i].Width > maxW || rectangles[i].Y + rectangles[i].Height > maxH)
                    rectangles.RemoveAt(i);
            }
        }

        public void Click(Point p, Boolean downRight) // down = false, right = true
        {
            foreach (Rectangle rec in rectangles)
            {
                if (rec.IsClicked(p))
                {
                    if(!downRight && !rec.movingRight) // move down
                    {
                        rec.movingDown = true;
                    }
                    else if (downRight && !rec.movingDown)
                    {
                        rec.movingRight = true;
                    }
                    return;
                }
            }

        }

        
    }
}
