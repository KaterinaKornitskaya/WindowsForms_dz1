using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
//     Задание 3
// Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей
// отстоят от границ рабочей области формы. Необходимо создать следующие обработчики: 
// ■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится
// текущая точка: внутри прямоугольника, снаружи, на границе прямоугольника.
// Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl),
// то приложение должно закрываться;
// ■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию
// о размере клиентской (рабочей) области окна в виде: Ширина = x, Высота = y,
// где x и y – соответствующие параметры вышего окна;
// ■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен
// выводить в заголовок окна текущие координаты мыши x и y
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)  // обработчик клика мышью
        {
            Form frm = (Form)sender;
            if (e.Button == MouseButtons.Left)     // если нажата левая кнопка мыши
            {
                if (ModifierKeys == Keys.Control)  // если при этом нажата клавиша Сtrl
                {
                    Close();                       // закрыто приложение
                }
                if (e.X < 10 || e.X > (ClientSize.Width - 10)  // если клик снаружи прямоугольника
                    || e.Y < 10 || e.Y > (ClientSize.Height - 10))
                {
                    frm.Text = String.Format("Клик снаружи прямоугольника.");
                }
                else if (e.X == 10 || e.X == (ClientSize.Width - 10)  // если клик снаружи прямоугольника
                    || e.Y == 10 || e.Y == (ClientSize.Height - 10))
                {
                    frm.Text = String.Format("Клик на границе прямоугольника.");
                }
                else  // в других случаях
                {
                    frm.Text = String.Format("Клик внутри прямоугольника.");
                }
                MessageBox.Show(frm.Text, "Сообщение", MessageBoxButtons.OK);
            }

            if (e.Button == MouseButtons.Right)  // если нажата правая кнопка мыши
            {
                frm.Text = $"Размере клиентской области окна! Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)  // обработчик движения мыши
        {
            Form frm = (Form)sender;
            frm.Text = String.Format($"x = {e.X}, y = {e.Y}");  // вывод координат
        }
    }
}
