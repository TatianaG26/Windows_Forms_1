using System;
using System.Windows.Forms;
/*Задание 1
Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). 
Причем на заголовке последнего должно отобразиться среднее число символов на странице 
(общее количество символов в резюме / количество MessageBox’ов).
*/
namespace WF_Введение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str1 = "Меня зовут Татьяна.";
            string str2 = "Я изучаю программирование.";
            string str3 = "На данный момент знаю языки С++, C#.";
            int length = str1.Length + str2.Length + str3.Length;
            MessageBox.Show(str1, "Резюме часть 1");
            MessageBox.Show(str2, "Резюме часть 2");
            MessageBox.Show(str3, "Среднее кол-во символов: " + length / 3);
        }
    }
}
