using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int total = 0;
        int buffer = 0;
        inputObj a = new inputObj();

        public Form1()
        {
            InitializeComponent();
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
            LblProcess.Text = "0";
            total = 0;
            buffer = 0;
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                total = int.Parse(result1.Text);
            }
            else
            {
                total = total + int.Parse(result1.Text);
            }
            result1.Text = a.keyinOp(result1.Text, btnPluse.Text);//把Operator放入文字
            LblProcess.Text += result1.Text;
            result1.Text = "0";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                total = int.Parse(result1.Text);
            }
            else
            {
                total = total - int.Parse(result1.Text);
            }
            result1.Text = a.keyinOp(result1.Text, btnMinus.Text);
            LblProcess.Text += result1.Text;
            result1.Text = "0";
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
            if (LblProcess.Text.EndsWith("+"))
            {
                total = total + int.Parse(result1.Text);
            } else if(LblProcess.Text.EndsWith("-")){
                total = total - int.Parse(result1.Text);
            }
            else if (LblProcess.Text.EndsWith("*"))
            {
                
            }
            else if (LblProcess.Text.EndsWith("/"))
            {
               
            }
            result1.Text =""+ total;
            buffer= 0;
            total = 0;
            LblProcess.Text += result1.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        
    }
}
