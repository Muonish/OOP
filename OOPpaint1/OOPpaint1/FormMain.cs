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
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Diagnostics;

namespace OOPpaint1
{
    public partial class FormMain : Form
    {
  
        public static Graphics GpanelHolst;
        public static FormDialog formD;
        public static Type currentFigure;
        Point pointBegin, pointEnd;
        FigureList figlst;

        public FormMain()
        {
            InitializeComponent();
            formD = new FormDialog();
            GpanelHolst = panelHolst.CreateGraphics();
            figlst = new FigureList(GpanelHolst);

            var lListOfBs = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                             from lType in lAssembly.GetTypes()
                             where typeof(Figure).IsAssignableFrom(lType)
                             select lType).ToArray();



            foreach (Type j in lListOfBs)
            {
                figureToolStripMenuItem.DropDownItems.Add(j.Name);
                Debug.WriteLine(j);
            }

            foreach (ToolStripMenuItem i in figureToolStripMenuItem.DropDownItems)
            {
                
                i.CheckStateChanged += new EventHandler(setCurrentFigure);
            }
                    //Console.WriteLine(j.Name);
                    //MessageBox.Show(j.Name);
            
        }

        private void setCurrentFigure(object sender, EventArgs e)
        {
            MessageBox.Show(((ToolStripMenuItem)sender).Text);
            currentFigure = Type.GetType(((ToolStripMenuItem)sender).Text);
            Debug.WriteLine(currentFigure, "OLOLOLOLOLO");
        }

        private void panelHolst_MouseDown(object sender, MouseEventArgs e)
        {
            pointBegin.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 10;
            pointBegin.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 31;
        }

        private void panelHolst_MouseUp(object sender, MouseEventArgs e)
        {
            pointEnd.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 10;
            pointEnd.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 31;
            //foreach (RadioButton rb in groupBoxFigures.Controls)
            //    MessageBox.Show(rb.Name.ToString());
            /*
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
             */
            //figlst.addToList(new (pointBegin, pointEnd));
            string[] a = new string[2];
            a[0] = pointBegin.ToString();
            a[1] = pointEnd.ToString();
            //a += pointBegin.ToString();
            //a += ",";
            //a += pointEnd.ToString();
            object[] param = {pointBegin, pointEnd};
            MessageBox.Show(currentFigure.Name);

            ConstructorInfo inf = currentFigure.GetConstructor(new Type[] { });
            var instance = (Figure)inf.Invoke(new object[] { });
            ((Ellipse)instance).initDef(pointBegin, pointEnd);
            //ConstructorInfo inf = currentFigure.GetConstructor(new Type[] { typeof(Point), typeof(Point) });
            //var instance = (Figure)inf.Invoke(new object[] {}, param);

            figlst.addToList(instance);
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            XmlSerializer writer = new XmlSerializer(typeof(FigureList));

            FileStream file = File.Create(saveFileDialog.FileName);
            writer.Serialize(file, figlst);
            file.Close();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            XmlSerializer reader = new XmlSerializer(typeof(FigureList));

            StreamReader file = new StreamReader(openFileDialog.FileName);
            figlst = (FigureList)reader.Deserialize(file);
            figlst.holst = GpanelHolst;
            figlst.DrawList();
        }


    }
}
