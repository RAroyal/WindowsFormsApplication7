using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {if (label1.Left < this.Width)
            {label1.Left += 2;}
            else
            {label1.Left = -label1.Width;}}
        private void button2_Click(object sender, EventArgs e)
        {//stop
            timer1.Stop();
            button1.Visible = true;
            label1.Visible = false;
            label6.Visible = false;
       }
        private void button1_Click_1(object sender, EventArgs e)
        {//avtor
            timer1.Start();
            button1.Visible = false;
            label1.Visible = true;
            button2.Visible = true;
            label6.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        { label1.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            label6.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Random RandomClass = new Random();
                textBox1.Text = RandomClass.Next(-5, 0).ToString();
                textBox2.Text = RandomClass.Next(-25, -5).ToString();
                textBox3.Text = RandomClass.Next(1, 5).ToString();
                textBox4.Text = RandomClass.Next(0, 20).ToString();

            }
            if (radioButton2.Checked == true)
            {
                if (checkBox5.Checked == true)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = true;}
                     if (checkBox1.Checked == true)
                    { textBox1.Text = "-4"; }
                    else
                    {Random RandomClass = new Random();
                        textBox1.Text = RandomClass.Next(-5, 0).ToString();}
                    if (checkBox2.Checked == true)
                    { textBox2.Text = "-6,2"; }
                    else
                    {Random RandomClass = new Random();
                        textBox2.Text = RandomClass.Next(-25, -5).ToString();}
                    if (checkBox3.Checked == true)
                    { textBox3.Text = "0,2"; }
                    else
                    {Random RandomClass = new Random();
                        textBox3.Text = RandomClass.Next(1, 5).ToString();}
                    if (checkBox4.Checked == true)
                    { textBox4.Text = "0,1"; }
                    else
                    {Random RandomClass = new Random();
                        textBox4.Text = RandomClass.Next(0, 15).ToString();}
                }
            }
        

        private void button4_Click(object sender, EventArgs e)
        {      }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox2.Text);
            double xk = Convert.ToDouble(textBox1.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double x = x0;
            while (x <= (xk + dx / 2))
            {

                double y = x + Math.Sqrt(Math.Abs(Math.Pow(x,3)+a+a*Math.Pow(Math.E,x)));;
                textBox5.Text += " x = " + Convert.ToString(x) + "; y = " + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        }

        }

     

        
    

