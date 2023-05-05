using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Задание 2
Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. 
Для запроса к пользователю использовать MessageBox. 
После того, как число отгадано, необходимо вывести количество запросов, 
потребовавшихся для этого, и предоставить пользователю возможность сыграть еще раз,
не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).
*/
namespace Задание_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            Random rnd = new Random();
            DialogResult result;
            int count = 1;     // переменная для колличества попыток
            MessageBox.Show("Угадаю число от 1 до 10.\nЗагадывайте число!");
            bool cont = true;  // переменная для цикла
            while (cont)
            {                
                result = MessageBox.Show($"{rnd.Next(1, 10)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // вывод на экран числo компьютера
                if (result == DialogResult.Yes)  // если компьютер угадал число
                {
                    result = MessageBox.Show($"Количество попыток {count}", "Угадал", MessageBoxButtons.OK, MessageBoxIcon.Question); 
                    
                    if (result == DialogResult.OK)  
                    {
                        cont = false;  // завершаем цикл                       
                    }
                }
                count++;  // суммирование попыток
            }
        }

    }
}