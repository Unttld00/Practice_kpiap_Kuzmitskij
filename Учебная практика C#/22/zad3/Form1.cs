using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-0,75";
            textBox2.Text = "-2,05";
            textBox3.Text = "-0,2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = -0.75;
                double xk = -2.05;
                double dx = -2.05;

                StringBuilder resultText = new StringBuilder();

                for (double x = x0; x <= xk; x += dx)
                {
                    double y = CalculateY(x);
                    resultText.AppendLine($"x = {x}, y = {y}");
                }

                textBox4.Text = resultText.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числа в текстовые поля.");
            }
        }
        double CalculateY(double x)
        {
            double term = 9 * Math.Pow(x, 4) + Math.Sin(57.2 + x);
            return term;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
