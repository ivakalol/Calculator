using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private double num1 = 0;
        private double num2 = 0;
        private bool isOperationPerformed = false;
        private bool clearTextBox1 = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numberButton(object sender, EventArgs e)
        {
            //if entering second number OR after computations
            if (clearTextBox1) 
            {
                textBox1.Text = "";
                clearTextBox1 = false;
            }
            double pressedButton = double.Parse(((Button)sender).Text);
            string combination = textBox1.Text + pressedButton.ToString();
            textBox1.Text = combination;
        }
        private void point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void operation(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                MessageBox.Show("Cannot perform two operations at once");                
            }
            else if (textBox1.Text.Length != 0)
            {
                Button button = (Button)sender;
                operationPerformed = button.Text;
                isOperationPerformed = true;
                clearTextBox1 = true;

                num1 = double.Parse(textBox1.Text);
                textBox2.Text = num1.ToString() + operationPerformed;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Error unknown");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //during operation
            if (isOperationPerformed && textBox1.Text.Length != 0) 
            {
                isOperationPerformed = false;
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            //during first num input
            else if ((textBox1.Text.Length > 0) && !isOperationPerformed)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                string combination = textBox1.Text;
                if (combination.Length == 0)
                {
                    num1 = 0;
                }
                else
                {
                    num1 = double.Parse(combination);
                }
                textBox1.Text = combination;
            }
            //during second num input
            else if ((textBox1.Text.Length > 0) && isOperationPerformed)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                string combination = textBox1.Text;
                if (combination.Length == 0)
                {
                    num2 = 0;
                }
                else
                {
                    num2 = double.Parse(combination);
                }
                textBox1.Text = combination;
            }
            else
            {
                MessageBox.Show("Nothing to delete");
                ResetComputation();
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            resultValue = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            num1 = 0;
            num2 = 0;
            isOperationPerformed = false;
            clearTextBox1 = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(textBox1.Text);
                switch (operationPerformed)
                {
                    case "+":
                        resultValue = num1 + num2;
                        break;
                    case "-":
                        resultValue = num1 - num2;
                        break;
                    case "*":
                        resultValue = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            resultValue = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                        }
                        break;
                    case "%":
                        resultValue = (num1 * num2) / 100;
                        break;
                    default:
                        MessageBox.Show("Error: Unknown operation.");
                        return;
                }
                textBox1.Text = resultValue.ToString();
                ResetComputation();
            }
            catch (Exception)
            {

                MessageBox.Show("Nothing to compute, give me some equation");
            }
            
        }

        private void ResetComputation()
        {
            if (operationPerformed == "%")
            {
                string output = num1 + operationPerformed + " of " + num2 + " = " + resultValue;
                History.Items.Add(output);
            }
            else if (operationPerformed != "")
            {
                string output = num1 + " " + operationPerformed + " " + num2 + " = " + resultValue;
                History.Items.Add(output);
            }
            
            num1 = 0;
            num2 = 0;
            textBox2.Text = string.Empty;
            isOperationPerformed = false;
            clearTextBox1 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
