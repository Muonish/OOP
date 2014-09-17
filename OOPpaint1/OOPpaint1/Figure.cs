using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPpaint1
{
    class Figure
    {
        public Point pointBegin, pointEnd;
        public virtual void Draw(Graphics g) { }


        public Figure(Point begin, Point end)
        {
            pointBegin = begin;
            pointEnd = end;
        }

    }
}
