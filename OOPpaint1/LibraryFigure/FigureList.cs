using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryFigure
{
    public class FigureList
    {
        private List<Figure> listFigure;
        private Graphics holst;

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
