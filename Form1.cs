using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int total = 0;
        inputObj a = new inputObj();

        public Form1()
        {
            InitializeComponent();
        }

        private void result1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinNum(result1.Text, btnNine.Text);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            result1.Text = "0";
            total = 0;
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            result1.Text=a.keyinOp(result1.Text, btnPluse.Text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinOp(result1.Text, btnMinus.Text);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinOp(result1.Text, btnMulti.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            result1.Text = a.keyinOp(result1.Text, btnDivide.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            result1.Text =""+ total;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
