using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button10.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }

            if (option.Equals("-"))
            {
                result = num1 - num2;
            }

            if (option.Equals("/"))
            {
                result = num1 / num2;
            }

            if (option.Equals("*"))
            {
                result = num1 * num2;
            }

            txtTotal.Text = result + "";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

    }
}
