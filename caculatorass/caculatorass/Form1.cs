using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculatorass
{
    public partial class Form1 : Form
    {
        bool isop = false;
        double FirstValue, SecondValue,resultValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnclearhistory.Visible = false;
        }

        private void numbercalculate(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            FirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            resultValue = double.Parse(txtResult.Text);
            showtxt.Text = resultValue + " " + op ;
            isop = true;
            txtResult.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(txtResult.Text);

            if ((op == "+") || (op == "-") || (op == "X") || (op == "÷"))
            {
                switch (op)
                {
                    case "+":
                        txtResult.Text = (FirstValue + SecondValue).ToString();
                        break;
                    case "-":
                        txtResult.Text = (FirstValue - SecondValue).ToString();
                        break;
                    case "X":
                        txtResult.Text = (FirstValue * SecondValue).ToString();
                        break;
                    case "÷":
                        txtResult.Text = (FirstValue / SecondValue).ToString();
                        break;
                    default:
                        break;

                }
                btnclearhistory.Visible = true;
                rtdisplay.AppendText(showtxt.Text + " " + SecondValue + " " + " = " + txtResult.Text + "\n");
                labelhistory.Text = "";
            }
            else
            {
                btnclearhistory.Visible = true;
                rtdisplay.AppendText(showtxt.Text + " " + " " + " = " + txtResult.Text + "\n");
                labelhistory.Text = "";
            }
        }

     

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnclearEmty_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            showtxt.Text = "";
            string f, s;
            f = Convert.ToString(FirstValue);
            s = Convert.ToString(SecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtdisplay.Clear();
            if(labelhistory.Text == "")
            {
                labelhistory.Text = "There's no history yet.";
               
            }
            btnclearhistory.Visible = false;
        }

        private void btnpersent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = System.Convert.ToString(a);
            showtxt.Text = txtResult.Text;
            labelhistory.Text = "There's no history yet.";
        }

        private void sqaure_Click(object sender, EventArgs e)
        {
            double sqaure;
            showtxt.Text = "sqr(" + txtResult.Text + ")";
            sqaure = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(sqaure);
            
        }

        private void root_Click(object sender, EventArgs e)
        {
            double squareRoot;
            showtxt.Text = "√(" + txtResult.Text + ")";
            squareRoot = Math.Sqrt(Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(squareRoot);
        }

        private void oneOnX_Click(object sender, EventArgs e)
        {
            double squareRoot;
            showtxt.Text = "1 / (" + txtResult.Text + ")";
            squareRoot = 1 / Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(squareRoot);
        }


        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if(txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num= (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {        
                if (num.Text == ".") {
                    if (!txtResult.Text.Contains("0"))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;

                }
            }
          





        }
    }
}
