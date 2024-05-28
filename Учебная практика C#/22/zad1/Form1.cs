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

namespace zad1
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
            textBox1.Text = "-0,02235";
            textBox2.Text = "2,23";
            textBox3.Text = "15,221";
            textBox4.Text = "39,374";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                double x = double.Parse(textBox1.Text);
                textBox5.Text += Environment.NewLine +
                "X = " + x.ToString();

                double y = double.Parse(textBox2.Text);
                textBox5.Text += Environment.NewLine +
                "Y = " + y.ToString();

                double z = double.Parse(textBox3.Text);
                textBox5.Text += Environment.NewLine +
                "Z = " + z.ToString();

                double phi = double.Parse(textBox4.Text);
                textBox5.Text += Environment.NewLine +
                    "Ф = " + phi.ToString();


                var result = Math.Exp(Math.Abs(x - y)) * Math.Pow(x - y, Math.Abs(x + y)) + Math.Pow(y + x, Math.Abs(x + y)) /
                             (Math.Atan(x) + Math.Atan(z)) + Math.Pow(y, 3) * Math.Sqrt(6 * x) + Math.Pow(Math.Log(y), 2);

                textBox5.Text += Environment.NewLine +
                "Результат = " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
