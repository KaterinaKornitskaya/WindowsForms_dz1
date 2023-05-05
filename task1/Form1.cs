using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
//     Задание 1
// Вывести на экран свое(краткое!!!) резюме с помощью последовательности
// MessageBox’ов(числом не менее трех). Причем на заголовке
// последнего должно отобразиться среднее число символов на странице
// (общее количество символов в резюме / количество MessageBox’ов).
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowCV();  // вызов метода Показать резюме
        }

        private void ShowCV()  // метод Показать резюме
        {
            string[] arr =     // массив строк резюме
            {
                "Имя: Корницкая Екатерина", "Возраст: 21", "Место учебы: IT Step Ukraine",
                "Направление: разработка программного обеспечения"
            };

            int symbols_count = 0;  // перемпнная для кол-ва символов
            string message;         // строка для сообщения
            for (int i = 0; i < arr.Length; i++)  // цикл по массиву строк
            {
                symbols_count += arr[i].Length;   // кол-во символов = длина строк массива
                if (arr.Length-1 == i)  // если выводится последнее сообщение - то вывод доп информации с кол-вом символов
                {
                    message = $"Сообщение {i+1}. Среднее кол-во символов = {symbols_count/arr.Length}";
                }
                else  // если выводится не последняя строка - вывод порядкового номера сообщения
                {
                    message = $"Сообщение {i+1}";
                }
                MessageBox.Show(arr[i], message, MessageBoxButtons.OK);  // вывод строк, нашего сообщения в заглавии, кнопки Ок

            }
        }
    }
}
