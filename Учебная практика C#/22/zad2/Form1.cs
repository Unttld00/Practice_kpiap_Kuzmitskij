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

namespace zad2
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
                double x = double.Parse(textBox1.Text);
                double m = double.Parse(textBox2.Text);

                double fx = Math.Pow(x, 2); 
                double j = 0;

                if (-1 < m && m < x)
                {
                    j = Math.Sin(5 * fx + 3 * m * Math.Abs(fx));
                }
                else if (x > m)
                {
                    j = Math.Cos(3 * fx + 5 * m * Math.Abs(fx));
                }
                else if (x == m)
                {
                    j = Math.Pow(fx + m, 2);
                }

                textBox3.Text = "Результат: j = " + j.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
