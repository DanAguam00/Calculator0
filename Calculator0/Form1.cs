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
        ReferenceClass refer = new ReferenceClass();


        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            if (refer.Operation != "")
            {
                if (TxtBx_2.Text != "")
                {
                    equal();
                    if (refer.MathError == false)
                    {
                        TxtBx_1.Text = TxtBx_1.Text + " = ";
                        refer.Value = float.Parse(TxtBx_2.Text);
                        refer.Operation = "";
                        TxtBx_1.Text = TxtBx_1.Text + TxtBx_2.Text;
                    }
                    else
                    {
                        refer.Operation = "";
                        TxtBx_2.Text = "Cannot Divide by Zero";
                        disableButtons(true);
                    }
                }
                else
                {
                    TxtBx_2.Text = "0";
                    equal();
                    if (refer.MathError == false)
                    {
                        TxtBx_1.Text = TxtBx_1.Text + " = ";
                        refer.Value = float.Parse(TxtBx_2.Text);
                        refer.Operation = "";
                        TxtBx_1.Text = TxtBx_1.Text + TxtBx_2.Text;
                    }
                    else
                    {
                        refer.Operation = "";
                        TxtBx_2.Text = "Cannot Divide by Zero";
                        disableButtons(true);
                    }
                }
            }
        }

        private void disableButtons(Boolean disable)
        {
            Btn_0.Enabled = !disable;
            Btn_1.Enabled = !disable;
            Btn_2.Enabled = !disable;
            Btn_3.Enabled = !disable;
            Btn_4.Enabled = !disable;
            Btn_5.Enabled = !disable;
            Btn_6.Enabled = !disable;
            Btn_7.Enabled = !disable;
            Btn_8.Enabled = !disable;
            Btn_9.Enabled = !disable;
            Btn_ClearEntry.Enabled = !disable;
            Btn_Dot.Enabled = !disable;
            Btn_Dvd.Enabled = !disable;
            Btn_Equal.Enabled = !disable;
            Btn_Minus.Enabled = !disable;
            Btn_Multiply.Enabled = !disable;
            Btn_OneOver.Enabled = !disable;
            Btn_Percent.Enabled = !disable;
            Btn_Plus.Enabled = !disable;
            Btn_Sqr.Enabled = !disable;
            Btn_Sqrt.Enabled = !disable;
            PlusMinus.Enabled = !disable;
        }
        private void equal()
        {
            if (refer.Operation.Equals("+"))
            {
                refer.Num1 = TxtBx_2.Text;
                refer.Add();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("-"))
            {
                refer.Num1 = TxtBx_2.Text;
                refer.Subtract();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("*"))
            {
                refer.Num1 = TxtBx_2.Text;
                refer.Multiply();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("/"))
            {
                if (TxtBx_2.Text != "0")
                {
                    refer.Num1 = TxtBx_2.Text;
                    refer.Divide();
                    TxtBx_2.Text = refer.Num1;
                }
                else
                {
                    refer.MathError = true;
                }
            }
            else if (refer.Operation.Equals("1/"))
            {
                if (TxtBx_2.Text != "0")
                {
                    refer.Num1 = TxtBx_2.Text;
                    refer.OneOver();
                    TxtBx_2.Text = refer.Num1;
                }
                else
                {
                    refer.MathError = true;
                }
            }
            else if (refer.Operation.Equals("sqr()"))
            {
                refer.Num1 = TxtBx_2.Text;
                refer.PowerSquare();
                TxtBx_2.Text = refer.Num1;
            }
            else if (refer.Operation.Equals("sqrt()"))
            {
                if (!TxtBx_2.Text.Contains("-"))
                {
                    refer.Num1 = TxtBx_2.Text;
                    refer.SquareRoot();
                    TxtBx_2.Text = refer.Num1;
                }
                else
                {
                    refer.MathError = true;
                }
            }
            else if (refer.Operation.Equals("%"))
            {
                refer.Num1 = TxtBx_2.Text;
                refer.Percent();
                TxtBx_2.Text = refer.Num1;
            }            
        }

        private void operation(String operation)
        {
            if (refer.Value != 0)
            {
                Btn_Equal.PerformClick();
                refer.OperationPressed = true;
                refer.Operation = operation;
                TxtBx_1.Text = refer.Value + " " + operation + " ";
            }
            else
            {
                if (TxtBx_1.Text != "")
                {
                    refer.Value = float.Parse(TxtBx_2.Text);
                    refer.OperationPressed = true;
                    refer.Operation = operation;
                    TxtBx_1.Text = TxtBx_1.Text + " " + operation + " ";
                }
            }
        }

        private void displayCharacter(String character)
        {
            if (refer.OperationPressed)
            {
                TxtBx_2.Text = "";
            }

            TxtBx_1.Text = TxtBx_1.Text + character;
            TxtBx_2.Text = TxtBx_2.Text + character;
            refer.OperationPressed = false;
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
            displayCharacter("4");
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

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
            if (!TxtBx_2.Text.Contains("."))
            {
                displayCharacter(".");
            }
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            operation("+");
            TxtBx_2.Text = "";
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            operation("-");
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            operation("*");
        }

        private void Btn_Dvd_Click(object sender, EventArgs e)
        {
            operation("/");
        }

        private void Btn_OneOver_Click(object sender, EventArgs e)
        {
            if (TxtBx_1.Text != "")
            {
                TxtBx_1.Text = "1/" + TxtBx_1.Text;
                refer.Operation = "1/";
                refer.OperationPressed = true;
            }
        }

        private void Btn_Sqr_Click(object sender, EventArgs e)
        {
            if (TxtBx_1.Text != "")
            {
                TxtBx_1.Text = "sqr(" + TxtBx_1.Text + ")";
                refer.Operation = "sqr()";
                refer.OperationPressed = true;
            }
        }

        private void Btn_Sqrt_Click(object sender, EventArgs e)
        {
            if (TxtBx_1.Text != "")
            {
                TxtBx_1.Text = "sqrt(" + TxtBx_1.Text + ")";
                refer.Operation = "sqrt()";
                refer.OperationPressed = true;
            }
        }

        private void Btn_Percent_Click(object sender, EventArgs e)
        {
            if (TxtBx_1.Text != "")
            {
                TxtBx_1.Text = TxtBx_1.Text + "%";
                refer.Operation = "%";
                refer.OperationPressed = true;
            }
        }

        private void Btn_GlobalClear_Click(object sender, EventArgs e)
        {
            disableButtons(false);
            refer.MathError = false;
            refer.Operation = "";
            refer.OperationPressed = false;
            refer.Value = 0;
            TxtBx_1.Text = "";
            TxtBx_2.Text = "";
        }

        private void Btn_ClearEntry_Click(object sender, EventArgs e)
        {
            TxtBx_2.Text = "";
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            if (refer.MathError == true)
            {
                disableButtons(false);
                refer.MathError = false;
                TxtBx_1.Text = TxtBx_1.Text.Substring(0, TxtBx_1.Text.Length - 1);
                if (TxtBx_1.Text.Substring(0, TxtBx_1.Text.Length - 1) == refer.Operation)
                {
                    refer.Operation = "";
                    refer.OperationPressed = false;
                }
            }
            else
            {
                if (TxtBx_1.Text.Length != 0)
                {
                    if (TxtBx_2.Text.Length != 0)
                    {
                        TxtBx_1.Text = TxtBx_1.Text.Substring(0, TxtBx_1.Text.Length - 1);
                        if (TxtBx_1.Text.Substring(0, TxtBx_1.Text.Length - 1) == refer.Operation)
                        {
                            refer.Operation = "";
                            refer.OperationPressed = false;
                        }
                        TxtBx_2.Text = TxtBx_2.Text.Substring(0, TxtBx_2.Text.Length - 1);
                    }
                }
            }
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (TxtBx_1.Text != "")
            {
                if (TxtBx_2.Text.StartsWith("-"))
                {
                    TxtBx_2.Text = TxtBx_2.Text.Substring(1);
                }
                else if ((!TxtBx_2.Text.Contains("-")) && float.Parse(TxtBx_2.Text) != 0)
                {
                    TxtBx_1.Text = "-" + TxtBx_1.Text;
                    TxtBx_2.Text = "-" + TxtBx_2.Text;
                }
            }
        }
    }
}
