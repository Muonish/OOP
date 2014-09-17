using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPpaint1
{
    public partial class FormDialog : Form
    {
        public int N = 0;
        //public static FormMain formD;

        public FormDialog()
        {
            InitializeComponent();
            //formM = new FormMain();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            this.Hide();
           // formM.radioButtonLine.Checked = false;
           // formM.radioButtonRect.Checked = false;
           // formM.radioButtonEllipse.Checked = false;
           // formM.radioButtonTriangle.Checked = false;
        }
    }
}
