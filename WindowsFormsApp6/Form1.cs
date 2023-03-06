using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            Double[] db = new Double[25];
            int sum = 0;
            int sum1 = 0;
            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                db[i] = Math.Round(rnd.NextDouble() * 10, 5);
                listBox1.Items.Add(-db[i]);

                if (-2<-db[i] && -db[i] <-1) { sum += 1; }
                if (db[i] > 0) { sum1 += 1; }

            }
            textBox1.Text += "a ∈[-2,-1]= " + sum.ToString() + Environment.NewLine;
            textBox1.Text += "a = " + sum1.ToString();
        }
    }
}
