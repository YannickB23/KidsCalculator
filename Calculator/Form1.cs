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
        double value = 0;
        string operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((displayResult.Text == "0") || (operationPressed))
            {
                displayResult.Clear();
            }
            operationPressed = false;
            Button button = (Button)sender;
            displayResult.Text = displayResult.Text + button.Text;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            displayResult.Text = "0";
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(displayResult.Text);
            operationPressed = true;
            //equation.Text = value + " " + operation;
        }
        private void equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    displayResult.Text = (value + Double.Parse(displayResult.Text)).ToString();
                    break;
                case "-":
                    displayResult.Text = (value - Double.Parse(displayResult.Text)).ToString();
                    break;
                case "*":
                    displayResult.Text = (value * Double.Parse(displayResult.Text)).ToString();
                    break;
                case "/":
                    displayResult.Text = (value / Double.Parse(displayResult.Text)).ToString();
                    break;
            }
        }
        private void clearRestoreValue_Click(object sender, EventArgs e)
        {
            displayResult.Clear();
            value = 0;
        }
    }
}
