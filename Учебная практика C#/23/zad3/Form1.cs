using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Создаем объект Graphics для рисования на форме
            Graphics g = e.Graphics;

            // Задаем цвет и размер полки
            Pen shelfPen = new Pen(Color.Blue, 2);
            int shelfWidth = 100;
            int shelfHeight = 10;

            // Рисуем полку
            g.DrawLine(shelfPen, 50, 50, 50 + shelfWidth, 50);
            g.DrawLine(shelfPen, 50, 50 + shelfHeight, 50 + shelfWidth, 50 + shelfHeight);

            // Освобождаем ресурсы
            shelfPen.Dispose();
        }


    }
}
