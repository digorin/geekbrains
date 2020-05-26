using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie7_2
{
    class Guess
    {

        public int Number { get; private set; }
        public string message = "";
        int count = 0;
        bool finished = false;

        public int Count
        {
            get { return count; }
        }

        public bool Finished
        {
            get { return finished; }
        }

        public Guess()
        {
            Number = new Random().Next(1, 101);
        }

        public int Check(int userguess)
        {
            count++;
            if(userguess == Number)
            {
                message = "Вы угадали. Игра окончена";
                finished = true;
                return 1;
            }
            else
            {
                if (userguess > Number)
                {
                    message = "Искомое число меньше Вашего";
                }
                else { message = "Искомое число больше Вашего"; }
                return -1;
            }
        }
    }
}
