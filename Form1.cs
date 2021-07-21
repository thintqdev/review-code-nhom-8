using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int So1, So2;
            So1 = int.Parse(textBox1.Text.ToString());
            So2 = int.Parse(textBox2.Text.ToString());
            double KETQUA;
            KETQUA = So1 / So2; 
            textBox3.Text = KETQUA.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int So1, So2;
            So1 = int.Parse(textBox1.Text.ToString());
            So2 = int.Parse(textBox2.Text.ToString());
            double KETQUA; 
            KETQUA = So1 + So2;
            textBox3.Text = KETQUA.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int So1, So2;
            So1 = int.Parse(textBox1.Text.ToString());
            So2 = int.Parse(textBox2.Text.ToString());
            double KETQUA;
            KETQUA = So1 - So2; 
            textBox3.Text = KETQUA.ToString();
        {
            int So1, So2;
            So1 = int.Parse(textBox1.Text.ToString());
            So2 = int.Parse(textBox2.Text.ToString());
            double KETQUA;
            KETQUA = So1 * So2;
            textBox3.Text = KETQUA.ToString();
        }
    }
}
