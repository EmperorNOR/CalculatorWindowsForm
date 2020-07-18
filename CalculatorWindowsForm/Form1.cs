using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {

        string formular;
        string number1;
        string number2;
        double answer;
        char clear = 'S';

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "0";

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += "9";
        }

        private void btnNumDecimal_Click(object sender, EventArgs e)
        {
            btnNumAnswer.Text += ".";
        }

        private void btnNumClear_Click(object sender, EventArgs e)
        {
            if (clear == 'S')
            {
                btnNumAnswer.Text = btnNumAnswer.Text.Remove(btnNumAnswer.Text.Length - 1);
            }
            else if (clear == 'A')

            {
                btnNumAnswer.Text = btnNumAnswer.Text = "";
            }
        }

        private void btnNumPlus_Click(object sender, EventArgs e)
        {
            number1 = btnNumAnswer.Text;
            btnNumAnswer.Text = "";
            formular = "+"; 
        }

        private void btnNumMinus_Click(object sender, EventArgs e)
        {
            number1 = btnNumAnswer.Text;
            btnNumAnswer.Text = "";
            formular = "-";
        }

        private void btnNumMult_Click(object sender, EventArgs e)
        {
            number1 = btnNumAnswer.Text;
            btnNumAnswer.Text = "";
            formular = "*";
        }

        private void btnNumDiv_Click(object sender, EventArgs e)
        {
            number1 = btnNumAnswer.Text;
            btnNumAnswer.Text = "";
            formular = "/";
        }

        private void btnNumEqual_Click(object sender, EventArgs e)
        {
            number2 = btnNumAnswer.Text;
            btnNumAnswer.Text = "";
            double FirstNumber = System.Convert.ToDouble(number1);
            double SecondNumber = System.Convert.ToDouble(number2);

            switch(formular)

            {
                case "+":
                    answer = FirstNumber + SecondNumber;
                    btnNumAnswer.Text = System.Convert.ToString(answer);
                    break;
                case "-":
                    answer = FirstNumber - SecondNumber;
                    btnNumAnswer.Text = System.Convert.ToString(answer);
                    break;
                case "*":
                    answer = FirstNumber * SecondNumber;
                    btnNumAnswer.Text = System.Convert.ToString(answer);
                    break;
                case "/":
                    answer = FirstNumber / SecondNumber;
                    btnNumAnswer.Text = System.Convert.ToString(answer);
                    break;
            }

            clear = 'A';
        }
    }
}
