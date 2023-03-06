using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int NextControlOffset = 0, next = 0;
        int TextBox = 0;
        int label = 0;
        int checkbox = 0;
        int linklabel = 0;
        int button = 0;
        Random _random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            NextControlOffset = 0;
            for (int i = 0; 10 > i; i++)
            {
                next = _random.Next(1, 6);
                int cord1 = _random.Next(1, 400);
                int cord2 = _random.Next(1, 400);
                switch (next)
                {
                    case 1:
                        TextBox TEXT = new TextBox();
                        TEXT.Visible = true;
                        TEXT.Enabled = true;
                        TextBox += 1;
                        TEXT.Text = "TEXTBOX" + TextBox;
                        textBox1.Text += "TEXTBOX" + TextBox.ToString() + "(" + cord1.ToString() + "; " + cord2.ToString() + ")" + "|||";
                        TEXT.Location = new Point(NextControlOffset + cord1,cord2);
                        AddControl(TEXT, panel1);
                        break;
                    case 2:
                        Label LABEL = new Label();
                        LABEL.Visible = true;
                        LABEL.Enabled = true;
                        label += 1;
                        LABEL.Text = "LABEL" + label;
                        textBox1.Text += "LABEL" + label.ToString() + "(" + cord1.ToString() + "; " + cord2.ToString() + ")" + "|||";
                        LABEL.Location = new Point(NextControlOffset + cord1, cord2);
                        AddControl(LABEL, panel1);
                        break;
                    case 3:
                        CheckBox CHECKBOX = new CheckBox();
                        CHECKBOX.Visible = true;
                        CHECKBOX.Enabled = true;
                        checkbox+= 1;
                        CHECKBOX.Text = "CHECKBOX" + checkbox;
                        textBox1.Text += "CHECKBOX" + checkbox.ToString() + "(" + cord1.ToString() + "; " + cord2.ToString() + ")" + "|||";
                        CHECKBOX.Location = new Point(NextControlOffset + cord1, cord2);
                        AddControl(CHECKBOX, panel1);
                        break;

                    case 4:
                        LinkLabel LINKLABEL = new LinkLabel();
                        LINKLABEL.Visible = true;
                        LINKLABEL.Enabled = true;
                        linklabel+= 1;
                        LINKLABEL.Text = "LINK LABEL" + linklabel;
                        textBox1.Text += "LINK LABEL" + linklabel.ToString() + "(" + cord1.ToString() + "; " + cord2.ToString() + ")" + "|||";
                        LINKLABEL.Location = new Point(NextControlOffset + cord1, cord2);
                        break;
                    case 5:
                        Button BUTTON = new Button();
                        BUTTON.Visible = true;
                        BUTTON.Enabled = true;
                        button += 1;
                        BUTTON.Text = "BUTTON" + button;
                        textBox1.Text += "BUTTON" + button.ToString() + "(" + cord1.ToString() + "; " + cord2.ToString() + ")" + "|||";
                        BUTTON.Location = new Point(NextControlOffset + cord1, cord2);
                        AddControl(BUTTON, panel1);
                        break;
                    default:
                        break;
                }
            }
        }
        void AddControl(Control _control, Control ToAdd)
        {
            NextControlOffset += 50;
            ToAdd.Controls.Add(_control);

        }
    }
}

