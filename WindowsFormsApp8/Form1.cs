using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
                double x0 = Convert.ToDouble(textBox1.Text); // -0,75
                double xk = Convert.ToDouble(textBox2.Text); // -2,05
                double dx = Convert.ToDouble(textBox3.Text); // -0,2
                double x01 = Convert.ToDouble(textBox4.Text);
                double yx = Convert.ToDouble(textBox5.Text);

                int count = Math.Abs((int)Math.Ceiling((x0 - xk) / dx) + 1);

                // Массив значений X – общий для обоих графиков 
                double[] x = new double[count];
                double[] x1 = new double[10];
                // Два массива Y – по одному для каждого графика 
                double[] y1 = new double[count];
                double[] y2 = new double[count * 2];

                for (int i = 0; i < count; i++)
                {
                    x[i] = x0 + dx * i;
                    y1[i] = 9 * Math.Pow(x[i], 4) + Math.Sin(57.2 + x[i]);

                }
                int i1 = -5;
                for (int i = 0; i < 10; i++)
                {
                    if (i < 5)
                        x1[i] = x01 + i1;
                    if (i >= 5)
                        x1[i] = x01 + i1;

                    y2[i] = Math.Pow(i1, 2) + yx;
                    i1++;
                }
                chart1.ChartAreas[0].AxisX.Minimum = -5;
                chart1.ChartAreas[0].AxisX.Maximum = 5;

                chart1.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = dx;

                chart1.Series[0].Points.DataBindXY(x, y1);
                for (int i = 0; i < count * 2; i++)
                {
                    Console.WriteLine("x" + x1[i] + "y" + y2[i]);
                    Console.Write(' ');
                }

                chart1.Series[1].Points.DataBindXY(x1, y2);
            }
            catch
            {
                MessageBox.Show("Введите данные корректно!");
            }
        }
    }
}
