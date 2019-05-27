using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class RecrangleDoc
    {
        public List<Rectangle> rectangles { get; set; }

        public RecrangleDoc()
        {
            this.rectangles = new List<Rectangle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle rec in rectangles)
                rec.Draw(g);
        }

        public void AddRectangle(Rectangle rec)
        {
            rectangles.Add(rec);
        }

        public Rectangle Clicked(Point p)
        {
            foreach (Rectangle rec in rectangles)
            {
                if (rec.isClicked(p))
                    return rec;
            }
            return null;
        }
    }
}
