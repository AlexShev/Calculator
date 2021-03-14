using System;
using System.Drawing;
using System.Windows.Forms;

namespace tempForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Height = 0;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var temp = new UserControl1();

            temp.label_1.Text = textBox1.Text;

            temp.buttonMMinus.Click += (sender, e) =>
            {
                temp.label_1.Text = (double.Parse(temp.label_1.Text) - double.Parse(textBox1.Text)).ToString();
            };

            temp.buttonMPlus.Click += (sender, e) =>
            {
                temp.label_1.Text = (double.Parse(temp.label_1.Text) + double.Parse(textBox1.Text)).ToString();
            };

            temp.buttonMC.Click += (sender, e) =>
            {
                flowLayoutPanel1.Controls.Remove(temp);
            };

            temp.Click += (sender, e) =>
            {
                textBox1.Text = temp.label_1.Text;

                panel1.Height = 0;
                button1.Enabled = true;
                button2.Enabled = true;
            };

            temp.label_1.Click += (sender, e) =>
            {
                textBox1.Text = temp.label_1.Text;

                panel1.Height = 0;
                button1.Enabled = true;
                button2.Enabled = true;
            };

            flowLayoutPanel1.Controls.Add(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                panel1.Height += 3;
            }

            button1.Enabled = false;

            button2.Enabled = false;
        }
    }
}
