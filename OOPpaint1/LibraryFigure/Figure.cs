using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryFigure
{
    public class Figure
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
