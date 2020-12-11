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
        char operation = char.MinValue;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            showresult.Text = "";
            input += (sender as Button).Text;
            showresult.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                showresult.Text = "";
                input += ".";
                showresult.Text += input;
            }
        }

        private void operand_cilck(object sender, EventArgs e)
        {
            operand1 = input;
            operation = char.Parse((sender as Button).Text);
            input = string.Empty;
        }

        private void equ_Click(object sender, EventArgs e)
        {
            operand2 = input;

            try
            {
                if (double.TryParse(operand1, out double num1) && double.TryParse(operand2, out double num2))
                {
                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case 'x':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                throw new ArithmeticException();
                            }
                            break;
                        case char.MinValue:
                        default:
                            break;
                    }

                    showresult.Text = input = result.ToString();
                }
            }
            catch (ArithmeticException)
            {
                showresult.Text = "Not Operational";
                resetValues();
            }
            catch (Exception ex)
            {
                showresult.Text = "Uh-oh, you've defeated the program!";
                resetValues();
                Console.WriteLine("Exception encountered. Error message: " + ex.Message);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            showresult.Text = "0";
            resetValues();
        }

        private void resetValues()
        {
            input = operand1 = operand2 = string.Empty;
            operation = char.MinValue;
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            showresult.Text = input = (0 - double.Parse(input)).ToString();
        }

        private void per_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(operand1, out num1);
            operand1 = input;
            result = double.Parse(operand1) / 100;
            showresult.Text = result.ToString();
            input = result.ToString();
        }
    }
}
