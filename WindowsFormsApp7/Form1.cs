using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        const int size = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.RowCount = size;
            dataGridView1.ColumnCount = size; // Кол‐во столбцов 
            dataGridView2.RowCount = size;
            dataGridView2.ColumnCount = size;

            int[,] a = new int[size, size]; // Инициализируем массив
            int i, j, max = 0, maxRow = 0, maxCell = 0;
            Random rand = new Random(); //Заполняем матрицу случайными числами 

            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }

            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    if (a[i, j] > max) 
                    {
                        max = a[i, j];
                        maxRow = i;
                        maxCell = j;
                    }
                
            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    if (i == maxRow || j == maxCell)
                        a[i, j] = 0;

            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();

            textBox1.Text = $"Наибольший элемент: {max}";

        }
    }
}