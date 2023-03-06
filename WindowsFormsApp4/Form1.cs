using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Результаты работы программы " + "ст. Косаревой Л.О. " + Environment.NewLine;

            double x = x0;
            while (x >= xk)
            {
                double y = 9 + Math.Pow(x, 4) + Math.Sin(57.2 + x);
                textBox4.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
