using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
            label1.Text = "Начало работы";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
