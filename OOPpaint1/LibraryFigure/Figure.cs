using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace LibraryFigure
{
    [XmlType("Figure")]
    public class Figure
    {
        [XmlElement("pointBegin")]
        public Point pointBegin;

        [XmlElement("pointEnd")]
        public Point pointEnd;

        public virtual void Draw(Graphics g) { }

        public Figure() { }
        public Figure(Point begin, Point end)
        {
            pointBegin = begin;
            pointEnd = end;
        }
    }
}
