using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void if_zero()
        {
            if(this.label1.Text == "0")
            {
                this.label1.Text = "";
            }
        }
        //Backspace
        private void button15_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            if(top_box != "" && top_box !="0")
            {
                top_box = top_box.Remove(top_box.Length - 1,1);
            }
            this.label1.Text = top_box;
        }

        //ClEAR
        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.ResetText();
            this.cur_operat_label.ResetText();
            this.all_operat_label.ResetText();
        }
        //0
        private void button10_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "0"; ;
            }
        }
        //1
        private void button7_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "1"; ;
            }
            
        }
        //2
        private void button8_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "2"; ;
            }
        }
        //3
        private void button9_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "3"; ;
            }
        }
        //4
        private void button4_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "4"; ;
            }
        }
        //5
        private void button5_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "5"; ;
            }
        }
        //6
        private void button6_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "6"; ;
            }
        }
        //7
        private void button1_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "7"; ;
            }
        }
        //8
        private void button2_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "8"; ;
            }
        }
        //9
        private void button3_Click(object sender, EventArgs e)
        {
            if_zero();
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box.Length < 15)
            {
                this.label1.Text += "9"; ;
            }
        }
        //-
        private void button11_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            String all_op = this.all_operat_label.Text;
            this.cur_operat_label.Text = "-";
            if (top_box == "")
            {
                if(all_op == "")
                {
                    this.all_operat_label.Text = "0";
                }
            }
            else
            {
                this.all_operat_label.Text = top_box;
            }
            this.label1.ResetText();
        }
        //+
        private void button12_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            String all_op = this.all_operat_label.Text;
            this.cur_operat_label.Text = "+";
            if (top_box == "")
            {
                if (all_op == "")
                {
                    this.all_operat_label.Text = "0";
                }
            }
            else
            {
                this.all_operat_label.Text = top_box;
            }
            this.label1.ResetText();
        }
        //mult
        private void button13_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            String all_op = this.all_operat_label.Text;
            this.cur_operat_label.Text = "*";
            if (top_box == "")
            {
                if (all_op == "")
                {
                    this.all_operat_label.Text = "0";
                }
            }
            else
            {
                this.all_operat_label.Text = top_box;
            }
            this.label1.ResetText();
        }
        //division
        private void button14_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            String all_op = this.all_operat_label.Text;
            this.cur_operat_label.Text = "/";
            if (top_box == "")
            {
                if (all_op == "")
                {
                    this.all_operat_label.Text = "0";
                }
            }
            else
            {
                this.all_operat_label.Text = top_box;
            }
            this.label1.ResetText();
        }
        //+ / -
        private void button20_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            if (top_box != "0" && top_box != "")
            {
                if(top_box.Substring(0,1) != "-")
                {
                    if (top_box.Length > 14)
                    {
                        MessageBox.Show("Sorry, too big of a number");
                    }
                    else
                    {
                        top_box = "-" + top_box;
                    }
                }
                else
                {

                    top_box = top_box.Remove(0, 1);
                }
                this.label1.Text = top_box;
            }
        }

        //mod
        private void button17_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            String all_op = this.all_operat_label.Text;
            this.cur_operat_label.Text = "%";
            if (top_box == "")
            {
                if (all_op == "")
                {
                    this.all_operat_label.Text = "0";
                }
            }
            else
            {
                this.all_operat_label.Text = top_box;
            }
            this.label1.ResetText();
        }
        //decimal or .
        private void button19_Click(object sender, EventArgs e)
        {
            String top_box = this.label1.Text;
            if (!top_box.Contains('.') && top_box != "" && top_box.Length < 15)
            {
                top_box += ".";
                this.label1.Text = top_box;
            }
        }
        //=
        private void button18_Click(object sender, EventArgs e)
        {
            String all_op = this.all_operat_label.Text;
            String cur_op = this.cur_operat_label.Text;
            String top_box = this.label1.Text;
            //First Number
            double f_num;
            double.TryParse(all_op, out f_num);
            //Second number
            double s_num;
            double.TryParse(top_box, out s_num);

            double result = 0;
            if (cur_op =="-")
            {
                result = f_num - s_num;
            }
            if(cur_op == "+")
            {
                result = f_num + s_num;
            }
            if (cur_op == "/")
            {
                if(s_num !=0)
                {
                    result = f_num / s_num;
                }
                else
                {
                    MessageBox.Show("Division by 0");
                    result = 0;
                }
            }
            if (cur_op == "*")
            {
                result = f_num * s_num;
            }
            if (cur_op == "%")
            {
                result = f_num % s_num;
            }
            this.label1.Text = result.ToString();
            this.cur_operat_label.ResetText();
            this.all_operat_label.ResetText();
        }
        private void cur_operat_label_Click(object sender, EventArgs e)
        {

        }

        private void all_operat_label_Click(object sender, EventArgs e)
        {

        }
    }
}
