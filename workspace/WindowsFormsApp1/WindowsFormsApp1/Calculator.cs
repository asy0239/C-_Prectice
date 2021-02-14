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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "바뀜";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 

        }


        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            int res = num1 + num2;
            result.Text = res.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            int res = num1 - num2;
            result.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            int res = num1 * num2;
            result.Text = res.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            int res = num1 / num2;

            result.Text = res.ToString();

        }
    }
}
