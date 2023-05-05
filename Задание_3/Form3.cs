using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Задание 3
  Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы. 
  Необходимо создать следующие обработчики:
■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: 
  внутри прямоугольника, снаружи, на границе прямоугольника.
  Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
  (рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
  текущие координаты мыши x и y.
*/
namespace Задание_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + e.X.ToString() + ", Y = " + e.Y.ToString();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rectangle = new Rectangle(10, 10, this.ClientSize.Width - 50, this.ClientSize.Height - 50);
            // создание прямоугольника в 10 пикселей от границы формы

            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close();
                }
                else if (e.X >= rectangle.Left && e.X <= rectangle.Right && e.Y >= rectangle.Top && e.Y <= rectangle.Bottom)
                {
                    MessageBox.Show("Точка находится внутри прямоугольника", "Окна сообщений");
                }
                else if ((e.X >= rectangle.Left - 10 && e.X <= rectangle.Left) || (e.X >= rectangle.Right && e.X <= rectangle.Right + 10)
                    || (e.Y >= rectangle.Top - 10 && e.Y <= rectangle.Top) || (e.Y >= rectangle.Bottom && e.Y <= rectangle.Bottom + 10))
                {
                    MessageBox.Show("Точка находится на границе прямоугольника", "Окна сообщений");
                }
                else
                {
                    MessageBox.Show("Точка находится снаружи прямоугольника", "Окна сообщений");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = "Ширина = " + this.ClientSize.Width.ToString() + ", Высота = " + this.ClientSize.Height.ToString();
            }
        }
    }
}
