using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;


namespace LibraryFigure
{
    [XmlType("Rectangle")]
    public class Rectangle : Figure
    {
        public Rectangle() { }
        public Rectangle(Point begin, Point end): base (begin, end)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black, 2F), pointBegin.X, pointBegin.Y,
                                                      pointEnd.X - pointBegin.X, pointEnd.Y - pointBegin.Y);
        }
    }
}
