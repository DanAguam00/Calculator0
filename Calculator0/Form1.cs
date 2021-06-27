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
<<<<<<< Updated upstream
        String operation = "";
        Boolean operationPressed = false;
        String num0 = "";
        String num2 = "";
=======
        ReferenceClass refer = new ReferenceClass();
        operationClass ops = new operationClass();
>>>>>>> Stashed changes

        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " = ";

<<<<<<< Updated upstream
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
=======
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
>>>>>>> Stashed changes
            }

            TxtBx_1.Text = TxtBx_1.Text + TxtBx_2.Text;
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "0";
            TxtBx_2.Text = TxtBx_2.Text + "0";
            operationPressed = false;
=======
            displayCharacter("0");
>>>>>>> Stashed changes
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "1";
            TxtBx_2.Text = TxtBx_2.Text + "1";
            operationPressed = false;
=======
            displayCharacter("1");
>>>>>>> Stashed changes
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "2";
            TxtBx_2.Text = TxtBx_2.Text + "2";
            operationPressed = false;
=======
            displayCharacter("2");
>>>>>>> Stashed changes
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "3";
            TxtBx_2.Text = TxtBx_2.Text + "3";
            operationPressed = false;
=======
            displayCharacter("3");
>>>>>>> Stashed changes
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "4";
            TxtBx_2.Text = TxtBx_2.Text + "4";
            operationPressed = false;
=======
            displayCharacter("5");
>>>>>>> Stashed changes
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "5";
            TxtBx_2.Text = TxtBx_2.Text + "5";
            operationPressed = false;
=======
            displayCharacter("5");
>>>>>>> Stashed changes
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "6";
            TxtBx_2.Text = TxtBx_2.Text + "6";
=======
            displayCharacter("6");
>>>>>>> Stashed changes
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "7";
            TxtBx_2.Text = TxtBx_2.Text + "7";
            operationPressed = false;
=======
            displayCharacter("7");
>>>>>>> Stashed changes
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if (operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "8";
            TxtBx_2.Text = TxtBx_2.Text + "8";
            operationPressed = false;
=======
            displayCharacter("8");
>>>>>>> Stashed changes
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            if(operationPressed)
            {
                num0 = TxtBx_2.Text;
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + "9";
            TxtBx_2.Text = TxtBx_2.Text + "9";
            operationPressed = false;
=======
            displayCharacter("9");
>>>>>>> Stashed changes
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " + ";
<<<<<<< Updated upstream
            operation = "+";
            operationPressed = true;
=======
            refer.Operation = "+";
            refer.OperationPressed = true;
>>>>>>> Stashed changes
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " - ";
<<<<<<< Updated upstream
            operation = "-";
            operationPressed = true;
=======
            refer.Operation = "-";
            refer.OperationPressed = true;
>>>>>>> Stashed changes
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " * ";
<<<<<<< Updated upstream
            operation = "*";
            operationPressed = true;
=======
            refer.Operation = "*";
            refer.OperationPressed = true;
>>>>>>> Stashed changes
        }

        private void Btn_Dvd_Click(object sender, EventArgs e)
        {
            TxtBx_1.Text = TxtBx_1.Text + " / ";
<<<<<<< Updated upstream
            operation = "/";
            operationPressed = true;
=======
            refer.Operation = "/";
            refer.OperationPressed = true;
>>>>>>> Stashed changes
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            TxtBx_1.Text = TxtBx_1.Text + ".";
            TxtBx_2.Text = TxtBx_2.Text + ".";
            operationPressed = false;
=======
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
>>>>>>> Stashed changes
        }
    }
}
