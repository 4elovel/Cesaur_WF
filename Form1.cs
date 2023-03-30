using System;
using System.Numerics;

namespace Cesaur_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int step = Convert.ToInt32(textBox3.Text) % 33;
            //label1.Text = str;
            string alphabet = "àáâã´äåºæçè³¿éêëìíîïğñòóôõö÷øùüşÿ";
            str.ToLower();
            string res = string.Empty;

            if( step == 0 )
            {
                label1.Text = str;
                return;
            }

                foreach (char i in str)
                {
                int leaver = 0;
                foreach (char c in alphabet)
                {
                    if (i == c)
                    {
                        leaver = 1;
                        break;
                    }
                }
                if ( leaver == 0 )
                {
                    res = res.Insert(res.Length, Convert.ToString(i));
                }

                    for (int j = 0; j < alphabet.Length; j++)
                    {
                    
                        if (alphabet[j] == i)
                        {
                        if (step > 0 && j + step >= alphabet.Length)
                        {
                            int new_step = j + step - alphabet.Length;
                            res = res.Insert(res.Length, Convert.ToString(alphabet[new_step]));
                        }
                        else if (step < 0 && j + step < 0)
                        {
                            int new_step = alphabet.Length + step + j;
                            res = res.Insert(res.Length, Convert.ToString(alphabet[new_step]));

                        }
                        else
                        {
                            res = res.Insert(res.Length, Convert.ToString(alphabet[j + step]));
                        }
                        }
                    }
                }
                label1.Text = res;




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}