using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public int random()
        {
            Random r = new Random(1000);

            int x = r.Next(DateTime.Now.Millisecond);
            return x;
        }

        int randomnumber = random();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string texts = Convert.ToString(randomnumber);
            label1.Text = (texts);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (textBox1.Text == "")
                label2.Text = ("Введите число, строка пустая");
            else
            {
                int number = Convert.ToInt32(this.textBox1.Text);
                i = Convert.ToString(i);
                if (randomnumber == number)
                    label2.Text = ("Вы угадали число, количество попыток", i);

                else
                {
                    i++;
                    label2.Text = ("U didn't guess");
                }
                
            }
            
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            random();
        }
    }
}
