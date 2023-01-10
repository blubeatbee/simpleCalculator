using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class window1 : Form
    {
        double first; //Första operanden. Alltså talen för kalkylationen
        double second; //Andra operanden
        char operation = ' '; //En operator är '+', '-', '*', '/' som används för kalkylation. Kallas operation istället för operator eftersom operator är reserverad
        double result; //Resultaten av operanderna efter kalkylationen
        public window1()
        {
            InitializeComponent();
        }

        private void OperationAddition() //Metoder som kalkylerar resultaten baserat på operatorn
        {
            result = first + second; //Dessa körs även om operator är ej satt
            calculateBox.Text = Convert.ToString(result); //Visar resultatet på '.Text'
        }
        private void OperationSubtraction()
        {
            result = first - second;
            calculateBox.Text = Convert.ToString(result);
        }
        private void OperationMultiplication()
        {
            result = first * second;
            calculateBox.Text = Convert.ToString(result);
        }
        private void OperationDivision()
        {
            result = first / second;
            calculateBox.Text = Convert.ToString(result);
        }


        private void buttonZero_Click(object sender, EventArgs e)
        {
            calculateBox.Text = calculateBox.Text + "0";
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "1";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "1";
            }
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "2";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "2";
            }
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "3";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "3";
            }
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "4";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "4";
            }
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "5";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "5";
            }
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "6";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "6";
            }
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "7";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "7";
            }
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "8";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "8";
            }
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "9";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + "9";
            }
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (calculateBox.Text == "0" && calculateBox.Text != null)
            {
                calculateBox.Text = "0,";
            }
            else
            {
                calculateBox.Text = calculateBox.Text + ",";
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            first = Double.Parse(calculateBox.Text); //Sätter talet till 'first' innan vi startar med det andra operanden 
            calculateBox.Text = "0";
            operation = '+'; //Sätter operatorn till '+' för kalkylationen

            buttonAdd.BackColor = Color.LightSteelBlue;
            buttonSubtract.BackColor = Color.Gainsboro;
            buttonMultiply.BackColor = Color.Gainsboro;
            buttonDivide.BackColor = Color.Gainsboro;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        { 
            first = Double.Parse(calculateBox.Text); //Den sätter även 'result' till 'first' om en kalkylationen gjordes tidigare 
            calculateBox.Text = "0";
            operation = '-';

            buttonAdd.BackColor = Color.Gainsboro;
            buttonSubtract.BackColor = Color.LightSteelBlue;
            buttonMultiply.BackColor = Color.Gainsboro;
            buttonDivide.BackColor = Color.Gainsboro;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            first = Double.Parse(calculateBox.Text);
            calculateBox.Text = "0";
            operation = '*';

            buttonAdd.BackColor = Color.Gainsboro;
            buttonSubtract.BackColor = Color.Gainsboro;
            buttonMultiply.BackColor = Color.LightSteelBlue;
            buttonDivide.BackColor = Color.Gainsboro;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            first = Double.Parse(calculateBox.Text);
            { calculateBox.Text = "0"; }
            operation = '/';

            buttonAdd.BackColor = Color.Gainsboro;
            buttonSubtract.BackColor = Color.Gainsboro;
            buttonMultiply.BackColor = Color.Gainsboro;
            buttonDivide.BackColor = Color.LightSteelBlue;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operation != ' ') //Räknar endast om det finns en operator eftersom då vet den att 'first' har ett talvärde som användaren vill använda
            {
                second = Double.Parse(calculateBox.Text);

                if (operation == '+')
                {
                    OperationAddition();
                }
                else if (operation == '-')
                {
                    OperationSubtraction();
                }
                else if (operation == '*')
                {
                    OperationMultiplication();
                }
                else if (operation == '/')
                {
                    OperationDivision();
                }
            }
            operation = ' '; //Rensar operationen så den ej kan råka influerar senare kalkulationer 

            buttonAdd.BackColor = Color.Gainsboro;
            buttonSubtract.BackColor = Color.Gainsboro;
            buttonMultiply.BackColor = Color.Gainsboro;
            buttonDivide.BackColor = Color.Gainsboro;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculateBox.Text = "0";
            operation = ' ';

            if (first == 0 || second == 0)
            {
                buttonClear.Text = "AC";
            }
            if (buttonClear.Text == "AC")
            {
                first = 0;
                second= 0;
                buttonClear.Text = "C";
            }

            buttonAdd.BackColor = Color.Gainsboro;
            buttonSubtract.BackColor = Color.Gainsboro;
            buttonMultiply.BackColor = Color.Gainsboro;
            buttonDivide.BackColor = Color.Gainsboro;
        }
    }
}