﻿using System;
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
        ReferenceClass refer = new ReferenceClass();
        operationClass ops = new operationClass();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " = ";

            if (refer.Operation.Equals("+"))
            {
                refer.Num1 = TxtBx_2.Text;
                ops.Add();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("-"))
            {
                refer.Num1 = TxtBx_2.Text;
                ops.Subtract();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("*"))
            {
                refer.Num1 = TxtBx_2.Text;
                ops.Multiply();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("/"))
            {
                refer.Num1 = TxtBx_2.Text;
                ops.Divide();
                TxtBx_2.Text = refer.Num1;
            }

            TxtBx_1.Text = TxtBx_1.Text + TxtBx_2.Text;
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            displayCharacter("0");
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            displayCharacter("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            displayCharacter("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            displayCharacter("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            displayCharacter("5");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            displayCharacter("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            displayCharacter("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            displayCharacter("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            displayCharacter("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            displayCharacter("9");
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " + ";
            refer.Operation = "+";
            refer.OperationPressed = true;
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " - ";
            refer.Operation = "-";
            refer.OperationPressed = true;
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " * ";
            refer.Operation = "*";
            refer.OperationPressed = true;
        }

        private void Btn_Dvd_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " / ";
            refer.Operation = "/";
            refer.OperationPressed = true;
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
            displayCharacter(".");
        }

        private void displayCharacter(String character)
        {
            if (refer.OperationPressed)
            {
                refer.Num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + character;
            TxtBx_2.Text = TxtBx_2.Text + character;
            refer.OperationPressed = false;
        }
    }
}
