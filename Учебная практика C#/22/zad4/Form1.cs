using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text += textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            textBox6.Text += Environment.NewLine + "Пол: ";
            if (radioButton1.Checked == true) 
            {
                textBox6.Text += radioButton1.Text;
            }

            else if (radioButton2.Checked == true) 
            {
                textBox6.Text += radioButton2.Text;
            }

            textBox6.Text += Environment.NewLine + "Дата рождения: " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text;
            textBox6.Text += Environment.NewLine + "Место проживания: " + comboBox4.Text;
            textBox6.Text += Environment.NewLine + "Адрес эл. почты: " + textBox4.Text;
            textBox6.Text += Environment.NewLine + "Номер телефона: " + textBox5.Text + " " + comboBox5.Text;
            textBox6.Text += Environment.NewLine + "Опыт работы: " ;

            if (radioButton3.Checked == true)
            {
                textBox6.Text += radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                textBox6.Text += radioButton4.Text;
            }
            else if (radioButton5.Checked == true)
            {
                textBox6.Text += radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                textBox6.Text += radioButton6.Text;
            }
            else if (radioButton7.Checked == true)
            {
                textBox6.Text += radioButton7.Text;
            }

            textBox6.Text += Environment.NewLine + "Другие сведения: ";
            if(checkBox1.Checked == true) 
            {
                textBox6.Text += checkBox1.Text + ", ";
            }
            else if (checkBox2.Checked == true)
            {
                textBox6.Text +="имеется " + checkBox2.Text + ", Каиегории прав:  ";
            }
            else if (checkBox3.Checked == true)
            {
                textBox6.Text += checkBox3.Text + " ";
            }
            else if (checkBox4.Checked == true)
            {
                textBox6.Text += checkBox4.Text + " ";
            }
            else if (checkBox5.Checked == true)
            {
                textBox6.Text += checkBox5.Text + " ";
            }
            else if (checkBox6.Checked == true)
            {
                textBox6.Text += checkBox6.Text + " ";
            }

            textBox6.Text += Environment.NewLine + "Объем ЗП: От " + (numericUpDown1.Value).ToString() + " До " + (numericUpDown2.Value).ToString();
            textBox6.Text += Environment.NewLine + "Предпочитаемый график работы: ";
            if (radioButton8.Checked == true)
            {
                textBox6.Text += radioButton8.Text;
            }
            else if (radioButton9.Checked == true)
            {
                textBox6.Text += radioButton9.Text;
            }
            else if (radioButton10.Checked == true)
            {
                textBox6.Text += radioButton10.Text;
            }
            else if (radioButton11.Checked == true)
            {
                textBox6.Text += radioButton11.Text;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5 };
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6,
            radioButton7, radioButton8, radioButton9, radioButton10, radioButton11};
            CheckBox[] categoryCheckboxes = { checkBox1 , checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
            NumericUpDown[] numericUpDowns = { numericUpDown1 , numericUpDown2 };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in categoryCheckboxes)
            {
                checkBox.Checked = false;
            }

            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
