using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        // Properties
        private string userInput1 = "";
        private decimal userInput1Decimal;
        private decimal userInput2Decimal;
        private decimal result;

        // Operations => 1 = Plus, 2 = Minus, 3 = Multiply, 4 = Divide
        int operation = 0;

        // Constructor
        public Calculator()
        {
            InitializeComponent();
        }

        // Adds new value to input when a button is clicked
        private void acceptInput(string input) {
            if (userInput1.Length >= 1 && userInput1.StartsWith('0')) {
                userInput1 = "";
            }
            if (userInput1.Length <= 10) {
                userInput1 += input;
            }
        }

        // Sets input value as null and display 0
        private void initializeProgram() {
            mainDisplay.Text = "0".ToString();
        }
        private void updateDisplay() {
            mainDisplay.Text = userInput1.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            initializeProgram();
        }
        // Button 0 - Click
        private void zero_Click(object sender, EventArgs e)
        {
            if (!userInput1.StartsWith('0')) {
                acceptInput("0");
                updateDisplay();
            }
        }
        // Button 1 - Click
        private void one_Click(object sender, EventArgs e)
        {
            acceptInput("1");
            updateDisplay();
        }

        // AC button
        private void ac_Click(object sender, EventArgs e)
        {
            userInput1 = "";
            initializeProgram();
            userInput1Decimal = 0;
            userInput2Decimal = 0;
            secondaryDisplay.Text = "";
            operation = 0;
            result = 0;

        }

        // Button 2 - Click
        private void two_Click(object sender, EventArgs e)
        {
            acceptInput("2");
            updateDisplay();
        }

        // Button 3 - Click
        private void three_Click(object sender, EventArgs e)
        {
            acceptInput("3");
            updateDisplay();
        }
        // Button 4 - Click
        private void four_Click(object sender, EventArgs e)
        {
            acceptInput("4");
            updateDisplay();
        }
        // Button 5 - Click
        private void five_Click(object sender, EventArgs e)
        {
            acceptInput("5");
            updateDisplay();
        }
        // Button 6 - Click
        private void six_Click(object sender, EventArgs e)
        {
            acceptInput("6");
            updateDisplay();
        }
        // Button 7 - Click
        private void seven_Click(object sender, EventArgs e)
        {
            acceptInput("7");
            updateDisplay();
        }
        // Button 7 - Click
        private void eight_Click(object sender, EventArgs e)
        {
            acceptInput("8");
            updateDisplay();
        }
        // Button 9 - Click
        private void nine_Click(object sender, EventArgs e)
        {
            acceptInput("9");
            updateDisplay();
        }
        // Decimal button
        private void dot_Click(object sender, EventArgs e)
        {
            if (!userInput1.Contains(".")) {
                acceptInput(".");
                updateDisplay();
            }
        }
        // Remove last character button
        private void button1_Click(object sender, EventArgs e)
        {
            if (userInput1.Length > 0)
            {
                userInput1 = userInput1.Remove(userInput1.Length - 1, 1);
                updateDisplay();
                if (userInput1.Equals(""))
                {
                    mainDisplay.Text = "0".ToString();
                }
                // New functionality testing
                if (result != 0) {
                    userInput1 = result.ToString();
                    mainDisplay.Text = userInput1;
                    userInput1Decimal = 0;
                    userInput2Decimal = 0;
                    secondaryDisplay.Text = "";
                    operation = 0;
                    result = 0;
                }
            }
        }

        // Equal Button Operations

        private void equalButtonOperation(int operationLocal) {
            string sign = "";
            if (operationLocal == 1)
            {
                sign = " + ";
            }
            else if (operationLocal == 2)
            {
                sign = " - ";
            }
            else if (operationLocal == 3)
            {
                sign = " * ";
            }
            else if (operationLocal == 4)
            {
                sign = " / ";
            }
            if (userInput1.Equals(""))
            {
                userInput2Decimal = 0;
            }
            else
            {
                userInput2Decimal = decimal.Parse(userInput1);
            }
            secondaryDisplay.Text = userInput1Decimal.ToString() + sign + userInput2Decimal.ToString();
            if (operationLocal == 1)
            {
                result = userInput1Decimal + userInput2Decimal;
            }
            else if (operationLocal == 2)
            {
                result = userInput1Decimal - userInput2Decimal;
            }
            else if (operationLocal == 3)
            {
                result = userInput1Decimal * userInput2Decimal;
            }
            else if (operationLocal == 4)
            {
                if (userInput2Decimal != 0)
                {
                    result = userInput1Decimal / userInput2Decimal;
                }
            }
            mainDisplay.Text = (Math.Round(result, 9)).ToString();
            userInput1Decimal = Math.Round(result,9);
        }

        // Result Button
        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                    equalButtonOperation(1);
                    break;

                case 2:
                    equalButtonOperation(2);
                    break;
                case 3:
                    equalButtonOperation(3);
                    break;

                case 4:
                    equalButtonOperation(4);
                    break;

            }
        }

        private void operationClick(int operationLocal)
        {
            // Sign Indentifier
            string sign = "";
            if (operationLocal == 1) {
                sign = " + ";
            } else if (operationLocal == 2) {
                sign = " - ";
            }
            else if (operationLocal == 3)
            {
                sign = " * ";
            }
            else if (operationLocal == 4)
            {
                sign = " / ";
            }

            if (operation == operationLocal)
            {
                if (userInput2Decimal == 0 || !userInput1.Equals("") || !userInput1.Equals("0"))
                {
                    decimal output = 0;
                    decimal.TryParse(userInput1, out output);
                    userInput2Decimal = output;
                }
                secondaryDisplay.Text = userInput1Decimal.ToString() + sign + userInput2Decimal.ToString();
                
                if (operationLocal == 1)
                {
                    result = userInput1Decimal + userInput2Decimal;
                }
                else if (operationLocal == 2)
                {
                    result = userInput1Decimal - userInput2Decimal;
                }
                else if (operationLocal == 3)
                {
                    result = userInput1Decimal * userInput2Decimal;
                }
                else if (operationLocal == 4)
                {
                    if (userInput2Decimal != 0) {
                        result = userInput1Decimal / userInput2Decimal;
                    }   
                }
                mainDisplay.Text = (result).ToString();
                userInput1Decimal = result;
            }
            if (userInput1.Equals(""))
            {
                userInput1Decimal = 0;
            }
            else if (operation == 1 || operation == 2 || operation == 3 || operation == 4)
            {
                userInput1Decimal = result;
                userInput2Decimal = 0;
            }
            else
            {
                userInput1Decimal = decimal.Parse(userInput1);
            }

            if (operation != 1 || operation != 2 || operation != 3 || operation != 4)
            {
                secondaryDisplay.Text = userInput1Decimal.ToString() + sign;
                userInput1 = "";
                initializeProgram();
                operation = operationLocal;
            }
        }
        // Plus operation button
        private void plus_Click(object sender, EventArgs e)
        {
            operationClick(1);
        }

        // Minus Operation Button

        private void minus_Click(object sender, EventArgs e)
        {
            operationClick(2);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operationClick(3);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operationClick(4);
        }
    }
}
