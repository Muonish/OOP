using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using LibraryFigure;

namespace LibraryTrapezium
{
    [XmlType("Trapezium")]
    public class Trapezium : Figure
    {
        public Trapezium() { }
        public Trapezium(Point begin, Point end)
            : base(begin, end)
        {
        }

        public override void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 2F);
            var pb = new Point();
            var pe = new Point();

            pb.X = pointBegin.X + (int)Math.Round((double)((pointEnd.X - pointBegin.X) / 4),0);
            pb.Y = pointBegin.Y;
            pe.X = pointEnd.X - (int)Math.Round((double)((pointEnd.X - pointBegin.X) / 4), 0);
            pe.Y = pointBegin.Y;
            g.DrawLine(pen, pb, pe);
            g.DrawLine(pen, pe, pointEnd);
            pe.X = pointBegin.X;
            pe.Y = pointEnd.Y;
            g.DrawLine(pen, pointEnd, pe);
            g.DrawLine(pen, pe, pb);
        }
    }
}
