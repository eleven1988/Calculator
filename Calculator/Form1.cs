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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "0";
            showresult.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "1";
            showresult.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "2";
            showresult.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "3";
            showresult.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "4";
            showresult.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "5";
            showresult.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "6";
            showresult.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "7";
            showresult.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "8";
            showresult.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += "9";
            showresult.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += ".";
            showresult.Text += input;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation += '+';
            input = string.Empty;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation += '-';
            input = string.Empty;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation += '*';
            input = string.Empty;
        }

        private void div_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation += '/';
            input = string.Empty;
        }

        private void equ_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    showresult.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    showresult.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    showresult.Text = result.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        showresult.Text = result.ToString();
                        break;
                    }
                    else
                    {
                        showresult.Text = "Not Operational";
                        break;
                    }
                default:
                    break;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            input += "AC";
            showresult.Text = "0";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            input = "-" + input;
        }

        private void per_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(operand1, out num1);
            operand1 = input;
            result = num1 / 100;
            showresult.Text = result.ToString();
            input = result.ToString();
        }
    }
}
