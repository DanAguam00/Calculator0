using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0
{
    public partial class Calculator : Form
    {
        String operation = "";
        Boolean operationPressed = false;
        String num0 = "";
        String num2 = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " = ";

            if (operation.Equals("+"))
            {
                TxtBx_2.Text = (float.Parse(num0) + float.Parse(TxtBx_2.Text)).ToString();
            }
            else if (operation.Equals("-"))
            {
                TxtBx_2.Text = (float.Parse(num0) - float.Parse(TxtBx_2.Text)).ToString();
            }
            else if (operation.Equals("*"))
            {
                TxtBx_2.Text = (float.Parse(num0) * float.Parse(TxtBx_2.Text)).ToString();
            }
            else if (operation.Equals("/"))
            {
                TxtBx_2.Text = (float.Parse(num0)  / float.Parse(TxtBx_2.Text)).ToString();
            }

            TxtBx_1.Text = TxtBx_1.Text + TxtBx_2.Text;
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "0";
            TxtBx_2.Text = TxtBx_2.Text + "0";
            operationPressed = false;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "1";
            TxtBx_2.Text = TxtBx_2.Text + "1";
            operationPressed = false;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "2";
            TxtBx_2.Text = TxtBx_2.Text + "2";
            operationPressed = false;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "3";
            TxtBx_2.Text = TxtBx_2.Text + "3";
            operationPressed = false;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "4";
            TxtBx_2.Text = TxtBx_2.Text + "4";
            operationPressed = false;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "5";
            TxtBx_2.Text = TxtBx_2.Text + "5";
            operationPressed = false;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "6";
            TxtBx_2.Text = TxtBx_2.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "7";
            TxtBx_2.Text = TxtBx_2.Text + "7";
            operationPressed = false;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "8";
            TxtBx_2.Text = TxtBx_2.Text + "8";
            operationPressed = false;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if(operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "9";
            TxtBx_2.Text = TxtBx_2.Text + "9";
            operationPressed = false;
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " + ";
            operation = "+";
            operationPressed = true;
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " - ";
            operation = "-";
            operationPressed = true;
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " * ";
            operation = "*";
            operationPressed = true;
        }

        private void Btn_Dvd_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " / ";
            operation = "/";
            operationPressed = true;
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + ".";
            TxtBx_2.Text = TxtBx_2.Text + ".";
            operationPressed = false;
        }
    }
}
