using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryFigure
{
    public class Triangle : Figure
    {
        public Triangle(Point begin, Point end) : base(begin, end)
        {

        }


        public override void Draw(Graphics g)
        {
            Point p1 = new Point((pointBegin.X + (pointEnd.X - pointBegin.X) / 2), pointBegin.Y);
            Point p2 = new Point(pointBegin.X, pointEnd.Y);
            g.DrawLine(new Pen(Color.Black, 2F), p1, pointEnd);
            g.DrawLine(new Pen(Color.Black, 2F), pointEnd, p2);
            g.DrawLine(new Pen(Color.Black, 2F), p2, p1);
        }
    }
}