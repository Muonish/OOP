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
        Type[] lListOfBs;

        public FormMain()
        {
            InitializeComponent();
            formD = new FormDialog();
            GpanelHolst = panelHolst.CreateGraphics();
            figlst = new FigureList(GpanelHolst);

            lListOfBs = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                         from lType in lAssembly.GetTypes()
                         where typeof(Figure).IsAssignableFrom(lType)
                         select lType).ToArray();



            foreach (Type j in lListOfBs)
            {
                if (j.Name != "Figure")
                    figureToolStripMenuItem.DropDownItems.Add(j.Name);
            }

            foreach (ToolStripMenuItem i in figureToolStripMenuItem.DropDownItems)
            {
                i.Click += new EventHandler(setCurrentFigure);
            }            
        }

        private void setCurrentFigure(object sender, EventArgs e)
        {
            foreach (Type j in lListOfBs)
            {
                if (j.Name == ((ToolStripMenuItem)sender).Text)
                    currentFigure = j;
            }
        }

        private void panelHolst_MouseDown(object sender, MouseEventArgs e)
        {
            pointBegin.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 4;
            pointBegin.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 19;
        }

        private void panelHolst_MouseUp(object sender, MouseEventArgs e)
        {
            pointEnd.X = MousePosition.X - this.Location.X - panelHolst.Location.X - 4;
            pointEnd.Y = MousePosition.Y - this.Location.Y - panelHolst.Location.Y - 19;

            ConstructorInfo inf = currentFigure.GetConstructor(new Type[] { });
            var instance = (Figure)inf.Invoke(new object[] { });
            instance.pointBegin = pointBegin;
            instance.pointEnd = pointEnd;
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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
        private void addFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogDll.ShowDialog();
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

        private void openFileDialogDll_FileOk(object sender, CancelEventArgs e)
        {
            Type[] ListTypes;
            if (System.IO.File.Exists(openFileDialogDll.FileName))
            {
                Assembly Ass = Assembly.LoadFrom(openFileDialogDll.FileName);
                ListTypes = Ass.GetTypes(); // Чтение всех типов

                //foreach (Type j in ListTypes)
                //{
                //    Debug.WriteLine(j);
                //}
                /*
                Type[] temp = new Type[ListTypes.Length + lListOfBs.Length];
                int i = 0;
                foreach (Type j in lListOfBs)
                {
                    temp[i] = j;
                    i++;
                    Debug.WriteLine(temp[i]);

                }
                foreach (Type j in ListTypes)
                {
                    temp[i] = j;
                    i++;
                    Debug.WriteLine(temp[i]);
                }
                */
                //lListOfBs = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                //             from lType in lAssembly.GetTypes()
                //             where typeof(Figure).IsAssignableFrom(lType)
                //             select lType).ToArray();

                //figureToolStripMenuItem.DropDownItems.Clear();
                //foreach (Type j in lListOfBs)
                //{
                //    if (j.Name != "Figure")
                //        figureToolStripMenuItem.DropDownItems.Add(j.Name);
                //}

                //foreach (ToolStripMenuItem i in figureToolStripMenuItem.DropDownItems)
                //{
                //    i.Click += new EventHandler(setCurrentFigure);
                //} 
            }
            else
            {
                MessageBox.Show("Dll не найдена:" + openFileDialogDll.FileName);
            }
        }
    }
}
