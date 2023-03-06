using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double j = 0;
                double m = Convert.ToDouble(textBox2.Text);
                double x = Convert.ToDouble(textBox1.Text);
                bool r1 = radioButton1.Checked;
                bool r2 = radioButton2.Checked;
                bool r3 = radioButton3.Checked;
                string yr = null;
                textBox3.ReadOnly = true;
                textBox3.Text = "Результаты работы программы " + "ст. Косаревой Л.О. " + Environment.NewLine;
                textBox3.Text += "При M = " + textBox2.Text + Environment.NewLine;
                textBox3.Text += "При X = " + textBox1.Text + Environment.NewLine;
                double f = Math.Pow(x, 2);
                if (r1) { f = Math.Sin(x); }
                if (r2) { f = Math.Pow(x, 2); }
                if (r3) { f = Math.Exp(x); }
                if (-1 < m && m < x)
                {
                    j = Math.Round(Math.Sin(5 * f + 3 * m * Math.Abs(f)),3);
                    yr = "j = sin(5f(x) + 3m|f(x)|)";
                }
                else if (x > m)
                {
                    j = Math.Round(Math.Cos(3 * f + 5 * m * Math.Abs(f)),3);
                    yr = "j = sin(3f(x) + 5m|f(x)|)";
                }
                else if (x == m)
                {
                    j = Math.Round(Math.Pow(f + m, 2),3);
                    yr = "j = (f(x) + m)^2";
                }
                textBox3.Text += yr + Environment.NewLine + "J = " + j.ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
