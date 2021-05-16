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
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            if (Btn_Equal.Text == "=")
            {
                Btn_Equal.Text = "Done";
            }
            else
            {
                Btn_Equal.Text = "=";
            }
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "0";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "9";
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            Txtbx_1.Text = Txtbx_1.Text + "+";
        }
    }
}
