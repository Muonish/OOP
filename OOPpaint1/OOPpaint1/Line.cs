using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPpaint1
{
    class Line : Figure
    {
        public Line(Point begin, Point end) : base(begin, end)
        {

        }


        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black, 2F), pointBegin, pointEnd);
        }
    }
}
