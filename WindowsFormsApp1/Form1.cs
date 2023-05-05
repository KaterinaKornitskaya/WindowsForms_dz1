using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
//     Задание 2
// Написать функцию, которая «угадывает» задуманное пользователем число.
// Для запроса к пользователю использовать MessageBox.
// После того, как число отгадано, необходимо вывести
// количество запросов, потребовавшихся для этого, и предоставить
// пользователю возможность сыграть еще раз, не выходя из программы
// (MessageBox’ы оформляются кнопками и значками соответственно
// ситуации).
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            DialogResult result;
            int tries = 1;     // переменная для колличества попыток
            MessageBox.Show("Угадаю число от 1 до 10.\nЗагадывайте!");
            bool cont = true;  // переменная для цикла
            while (cont)
            {
                result = MessageBox.Show($"{rnd.Next(1, 10)}",
                    "Вы загадали число", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);    // вывод на экран числа компьютера
                if (result == DialogResult.Yes)  // если компьютер угадал число
                {
                    MessageBox.Show($"Колличество попыток {tries}",
                        "Угадал", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);  // выводится информация о кол-ве попыток
                    tries = 0;  // кол-во попыток обнуляется
                    result = MessageBox.Show($"Хотите продолжить?", 
                        "Выход", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);   // вывод сообщения "Сыграть еще?"
                                                    // если да  - возврат к предыдущей итерации
                    if (result == DialogResult.No)  // если нет
                    {
                        cont = false;  // завершаем цикл
                        this.Close();  // закрываем приложение
                    }
                }
                tries++;  // суммирование попыток
            }
        }
    }
}
