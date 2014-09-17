using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpaint1
{
    class FigureList
    {
        private List<Figure> listFigure;

        public FigureList()
        {
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
            for (int i = 0; i < listFigure.Count; i++ )
            {
                listFigure[i].Draw(FormMain.GpanelHolst);
            }
                
        
        }
    }




}
