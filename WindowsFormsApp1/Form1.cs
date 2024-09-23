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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool isOperationPressed = false;
        bool isFirstNumberEntered = false;


        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "1";
            isFirstNumberEntered = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "2";
            isFirstNumberEntered = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "3";
            isFirstNumberEntered = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }

            txtDisplay.Text += "4";
            isFirstNumberEntered = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "5";
            isFirstNumberEntered = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "6";
            isFirstNumberEntered = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "7";
            isFirstNumberEntered = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "8";
            isFirstNumberEntered = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "9";
            isFirstNumberEntered = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberEntered)
            {
                return;
            }
            Button button = (Button)sender;

            // If an operation is already pressed, just change the operation without performing calculation
            if (operation != "")
            {
                operation = "+";
                return;
            }

            // Convert the first number and store the operation
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            isOperationPressed = true;
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberEntered)
            {
                return;
            }
            Button button = (Button)sender;

            // If an operation is already pressed, just change the operation without performing calculation
            if (operation != "")
            {
                operation = "-";
                return;
            }

            // Convert the first number and store the operation
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = button.Text;
            isOperationPressed = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberEntered)
            {
                return;
            }
            Button button = (Button)sender;

            // If an operation is already pressed, just change the operation without performing calculation
            if (operation != "")
            {
                operation = "*";
                return;
            }

            // Convert the first number and store the operation
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            isOperationPressed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberEntered)
            {
                return;
            }
            Button button = (Button)sender;

            // If an operation is already pressed, just change the operation without performing calculation
            if (operation != "")
            {
                operation = "/";
                return;
            }

            // Convert the first number and store the operation
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation ="/" ;
            isOperationPressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberEntered)
            {
                return; // Prevent calculating if no valid numbers are entered
            }
            // Convert the second number
            secondNumber = Convert.ToDouble(txtDisplay.Text);

            // Perform the operation
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero");
                    break;
                default:
                    return; // No operation selected
            }

            // Display the result and reset the state for the next calculation
            txtDisplay.Text = result.ToString();
            firstNumber = result;
            operation = "";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isOperationPressed = false;
            isFirstNumberEntered = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Append digit only if operation has not been pressed
            if (isOperationPressed)
            {
                txtDisplay.Clear();
                isOperationPressed = false;
            }
            txtDisplay.Text += "0";
            isFirstNumberEntered = true;
        }
    }
}
