using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryFigure
{
    public class CustomFigure : Figure
    {
        int N;

        public CustomFigure(Point begin, Point end, int n) : base(begin, end)
        {
            N = n;
        }

        public override void Draw(Graphics g)
        {
            int i;
            int center_x;
            int center_y;
            int Radius;
            double temp;
            Point[] vector = new Point[N + 1];

            /* if (Math.Abs(pointEnd.X - pointBegin.X) > Math.Abs(pointEnd.Y - pointBegin.Y))
             {
                 if ((pointEnd.X - pointBegin.X) > 0) pointEnd.X = pointBegin.X + pointEnd.Y - pointBegin.Y;
                 else pointEnd.X = pointBegin.X - pointEnd.Y - pointBegin.Y;
             }
             else
             {
                 if ((pointEnd.Y - pointBegin.Y) > 0) pointEnd.Y = pointBegin.Y + pointEnd.X - pointBegin.X;
                 else pointEnd.Y = pointBegin.Y - pointEnd.X - pointBegin.X;
             }*/

            Radius = Math.Abs(pointBegin.X - pointEnd.X) / 2;
            temp = (pointEnd.X - pointBegin.X) / 2;
            center_x = pointBegin.X + (int)Math.Round(temp, 0);
            temp = (pointEnd.Y - pointBegin.Y) / 2;
            center_y = pointBegin.Y + (int)Math.Round(temp, 0);

            for (i = 0; i <= N - 1; i++)
            {
                vector[i] = new Point(center_x + Convert.ToInt16(Radius * Math.Cos(2 * i * Math.PI / N)),
                                      center_y + Convert.ToInt16(Radius * Math.Sin(2 * i * Math.PI / N)));
            }
            vector[N] = new Point(vector[0].X, vector[0].Y);
            g.DrawLines(new Pen(Color.Black, 2F), vector);
        }
    }
}
