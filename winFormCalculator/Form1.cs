using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormCalculator
{
    public partial class Form1 : Form
    {
        private bool opFlag = false;
        private bool memFlag = false;

        // 1 + 1 = ? 이라는 연산을 할 때
        // 첫번째 연산되는 숫자를 저장 할 필드
        private double savedValue;
        // 연산자를 저장할 필드
        private char op = '\0';

        private double memory;

        public Form1()
        {
            InitializeComponent();

            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(txtResult.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
            {
                txtResult.Text = txtResult.Text + btn.Text;
            }

            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(".")) return;
            else txtResult.Text += ".";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " + ";
            op = '+';
            opFlag = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " x ";
            op = 'x';
            opFlag = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + " / ";
            op = '/';
            opFlag = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double x = Double.Parse(txtResult.Text);

            switch (op)
            {
                case '+':
                    txtResult.Text = (savedValue + x).ToString();
                    break;
                case '-':
                    txtResult.Text = (savedValue - x).ToString();
                    break;
                case 'x':
                    txtResult.Text = (savedValue * x).ToString();
                    break;
                case '/':
                    txtResult.Text = (savedValue / x).ToString();
                    break;
            }
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = commaProcedure(v, txtResult.Text);

            txtExp.Text = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "√(" + txtResult.Text + ") ";
            txtResult.Text = Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + txtResult.Text + ") ";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtExp.Text = "1 / (" + txtResult.Text + ") ";
            txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
        }
        
        private void btnCE_Click(object sender, EventArgs e) 
        {
            txtResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            savedValue = 0;
            op = '\0';
            opFlag = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if(txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memFlag = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtResult.Text);
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtResult.Text);
        }

        private static string commaProcedure(double v, string s)
        {
            int pos = 0;

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                if(pos == 1)
                {
                    return s;
                }
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
            {
                s = string.Format("{0:N0}", v);
            }

            return s;

        }
    }
}
