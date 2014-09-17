using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryFigure;

namespace OOPpaint1
{
    public partial class FormMain : Form
    {
        public static Graphics GpanelHolst;
        public static FormDialog formD;
        public bool fTracking = false;
        Point pointBegin, pointEnd;
        FigureList figlst;
        Figure o;

        public FormMain()
        {
            InitializeComponent();
            //formD.Hide();
            formD = new FormDialog();
            GpanelHolst = panelHolst.CreateGraphics();
            figlst = new FigureList(GpanelHolst);
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            radioButtonLine.Checked = true;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }

        private void radioButtonLine_Click(object sender, EventArgs e)
        {
            radioButtonLine.Checked = true;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }

        private void radioButtonCircle_Click(object sender, EventArgs e)
        {
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = true;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }

        private void radioButtonRect_Click(object sender, EventArgs e)
        {
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = true;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }
        private void radioButtonTriangle_Click(object sender, EventArgs e)
        {
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = true;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }

        private void panelHolst_MouseDown(object sender, MouseEventArgs e)
        {
            //fTracking = true;
            pointBegin.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 10;
            pointBegin.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 31;
        }

        private void panelHolst_MouseUp(object sender, MouseEventArgs e)
        {
            //fTracking = false;
            pointEnd.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 10;
            pointEnd.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 31;
            if (radioButtonLine.Checked) figlst.addToList(new Line(pointBegin, pointEnd));
            else
                if (radioButtonRect.Checked) figlst.addToList(new LibraryFigure.Rectangle(pointBegin, pointEnd));
                else
                    if (radioButtonEllipse.Checked) figlst.addToList(new Ellipse(pointBegin, pointEnd));
                    else
                        if (radioButtonTriangle.Checked) figlst.addToList(new Triangle(pointBegin, pointEnd));
                        else
                            if (radioButtonSquare.Checked) figlst.addToList(new Square(pointBegin, pointEnd));
                            else
                                if (radioButtonCircle.Checked) figlst.addToList(new Circle(pointBegin, pointEnd));
                                else
                            figlst.addToList(new CustomFigure(pointBegin, pointEnd, formD.N));
            figlst.DrawList();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHolst.Refresh();
            figlst.clearList();
        }

        private void figureToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            formD.Show();
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = false;
        }

        private void radioButtonSquare_Click(object sender, EventArgs e)
        {
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = true;
            radioButtonCircle.Checked = false;
        }

        private void radioButtonCircle_Click_1(object sender, EventArgs e)
        {
            radioButtonLine.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonEllipse.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonCircle.Checked = true;
        }

    }
}
