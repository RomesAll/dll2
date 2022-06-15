using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DllMarkirovka.Class1 class1 = new DllMarkirovka.Class1();
            if (textBox1.TextLength == 14)
            {
                MessageBox.Show(class1.GetYear(textBox1.Text).ToString());
                MessageBox.Show(class1.GetFirma(textBox1.Text).ToString());
                MessageBox.Show(class1.GetNomer(textBox1.Text).ToString());
            }
        }
    }
}
