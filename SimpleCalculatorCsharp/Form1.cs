using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculatorCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tot = 0;
        string LogicalOperator;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn1.Text;
            }
            else
            {
                txtView.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn2.Text;
            }
            else
            {
                txtView.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn3.Text;
            }
            else
            {
                txtView.Text += btn3.Text;
            } 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn0.Text;
            }
            else
            {
                txtView.Text += btn0.Text;
            } 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn8.Text;
            }
            else
            {
                txtView.Text += btn8.Text;
            } 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn7.Text;
            }
            else
            {
                txtView.Text += btn7.Text;
            }
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn9.Text;
            }
            else
            {
                txtView.Text += btn9.Text;
            }
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn6.Text;
            }
            else
            {
                txtView.Text += btn6.Text;
            }
             
        }

        private void btn5_Click(object sender, EventArgs e)
        { 
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn5.Text;
            }
            else
            {
                txtView.Text += btn5.Text;
            } 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0")
            {
                txtView.Clear();
                txtView.Text += btn4.Text;
            }
            else
            {
                txtView.Text += btn4.Text;
            }
        }

        private void btnDote_Click(object sender, EventArgs e)
        {
            if (!txtView.Text.Contains("."))
            {
                txtView.Text += btnDote.Text;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtView.Text = "0";
            tot = 0;
           
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            tot += double.Parse(txtView.Text);
            LogicalOperator = "plus";
            txtView.Clear();


        }
       private void btnminus_Click(object sender, EventArgs e)
        {
            tot += double.Parse(txtView.Text);
            LogicalOperator = "minus";
            txtView.Clear();

        }
       private void btnMultiply_Click(object sender, EventArgs e)
       {
           tot += double.Parse(txtView.Text);
           LogicalOperator = "multiply";
           txtView.Clear();
       }

       private void btnDivide_Click(object sender, EventArgs e)
       {
           tot += double.Parse(txtView.Text);
           LogicalOperator = "divide";
           txtView.Clear();
       }
        private void btnEqual_Click(object sender, EventArgs e)
        {

            switch (LogicalOperator){
                case "plus":
                    tot = tot + double.Parse(txtView.Text);
                    txtView.Text = tot.ToString();
                    tot = 0;
                    LogicalOperator = "";
                    break ;
                case "minus":
                    tot = tot - double.Parse(txtView.Text);
                    txtView.Text = tot.ToString();
                    tot = 0;
                    LogicalOperator = ""; 
                    break;

                case "multiply":
                    tot = tot * double.Parse(txtView.Text);
                    txtView.Text = tot.ToString();
                    tot = 0;
                    LogicalOperator = "";
                    break;
                case "divide":
                    tot = tot / double.Parse(txtView.Text);
                    txtView.Text = tot.ToString();
                    tot = 0;
                    LogicalOperator = "";
                    break;
                default :
                    txtView.Text = tot.ToString(); 
                    break;

            }
                
             
             
              
        }
 
         
    }
}
