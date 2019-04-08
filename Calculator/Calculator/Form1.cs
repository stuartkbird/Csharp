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

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }
        double total1 = 0;
        double total2 = 0;
        string theOperator;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "*";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;

            num2 = double.Parse(txtDisplay.Text);
            
            switch (theOperator)
            {
                case "+":
                    answer = total1 + num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    
                    //total1 += double.Parse(txtDisplay.Text);
                    ////txtDisplay.Clear();

                    //theOperator = "+";
                    break;
                case "-":
                    answer = total1 - num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;

                    //total1 += double.Parse(txtDisplay.Text);
                    //txtDisplay.Clear();

                    //theOperator = "-";
                    break;
                case "/":
                    answer = total1 / num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;

                    //total1 += double.Parse(txtDisplay.Text);
                    //txtDisplay.Clear();

                    //theOperator = "/";
                    break;
                case "*":
                    answer = total1 * num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;


                    //total1 += double.Parse(txtDisplay.Text);
                    //txtDisplay.Clear();

                    //theOperator = "*";
                    break;
                default :
                    // default code here
                    break;
            }


            
        }

    }
}
