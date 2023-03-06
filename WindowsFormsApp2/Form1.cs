using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a=-2.235 * Math.Pow(10, -2);
            textBox1.Text = Convert.ToString(a);
            // Начальное значение Y 
            textBox2.Text = "2,23";
            // Начальное значение Z 
            textBox3.Text = "15,221";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X 
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно 
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Считывание значения Y 
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно 
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            // Считывание значения Z 
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно 
            textBox4.Text += Environment.NewLine + "F = " + z.ToString();
            // Вычисляем арифметическое выражение 
            double mul1 = Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), (x + y));
            double sum1= Math.Atan(x)+Math.Atan(z);
            double div1 = (mul1 / sum1);
            double sq = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2), (1 / 3));
            double sum2 = Math.Round(div1 + sq,2);
            // Выводим результат в окно 38,511 + 1
            textBox4.Text += Environment.NewLine + "Результат U = " + sum2.ToString();
        }
    }
}
