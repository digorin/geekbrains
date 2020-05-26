using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie7_2
{
    public partial class Form1 : Form
    {

        //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
        //a) Для ввода данных от человека используется элемент TextBox;
        //Горин Дмитрий

        Guess guess = new Guess();
        int status = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void CheckEnd(Guess guess)
        {
            if (guess.Finished == true)
            {
                label_tryCount.Text = "";
                label_message.Text = "";
                guess = new Guess();
            }

        }

        private void button_check_Click(object sender, EventArgs e)
        {
            try
            {
                status = guess.Check(int.Parse(textBox1.Text));
                label_tryCount.Text = guess.Count.ToString();
                label_message.Text = guess.message;
                if(status == 1)
                {
                    CheckEnd(guess);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}
