using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace LibraryFigure
{   
    [Serializable]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(CustomFigure))]
    [XmlInclude(typeof(Ellipse))]
    [XmlInclude(typeof(Line))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Triangle))]
    public class FigureList
    {
        public List<Figure> listFigure;
        [XmlIgnore()]
        public Graphics holst;

        public FigureList() { }
        public FigureList(Graphics g)
        {
            holst = g;
            listFigure = new List<Figure>();
        }

        public void addToList(Figure a)
        {
            listFigure.Add(a);
        }

        public void clearList()
        {
            listFigure.Clear();
        }

        public void DrawList()
        {
            foreach (Figure f in listFigure)
            {
                f.Draw(holst);
            }
        }
    }
}
