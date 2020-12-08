using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int y1 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            float duzina = (x2 - x1) * 2 + (y2 - y1)*2;
            float povrsina = (x2 - x1) * (y2 - y1);
            label7.Text = povrsina.ToString();
            label8.Text = duzina.ToString();
        }

    }
}
