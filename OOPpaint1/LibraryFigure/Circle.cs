using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace LibraryFigure
{
    [XmlType("Circle")]
    public class Circle : Ellipse
    {
        public Circle() { }
        
        public Circle(Point begin, Point end) : 
            base(begin, end)
        {
        }

        public override void Draw(Graphics g)
        {
            if (Math.Abs(pointEnd.X - pointBegin.X) > Math.Abs(pointEnd.Y - pointBegin.Y))
            {
                if ((pointEnd.X - pointBegin.X) > 0) pointEnd.X = pointBegin.X + pointEnd.Y - pointBegin.Y;
                else pointEnd.X = pointBegin.X - pointEnd.Y - pointBegin.Y;
            }
            else
            {
                if ((pointEnd.Y - pointBegin.Y) > 0) pointEnd.Y = pointBegin.Y + pointEnd.X - pointBegin.X;
                else pointEnd.Y = pointBegin.Y - pointEnd.X - pointBegin.X;
            }
            g.DrawEllipse(new Pen(Color.Black, 2F), pointBegin.X, pointBegin.Y,
                                                  pointEnd.X - pointBegin.X, pointEnd.Y - pointBegin.Y);
        }
    }
}
