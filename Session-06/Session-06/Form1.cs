using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06
{
    public partial class Form1 : Form
    {
        public Logger LoggerList = new Logger();
        public Form1()
        {
            InitializeComponent();
            LoggerList=new Logger();
            
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text += "1";
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
        }

        private void buttonMult_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text += "x";
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "**";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ":";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "=";

            

            var result = new MathOperation(this.textBox1.Text);
            //LoggerList.Insert(result.Result());

            //this.Logger.Text = result.Result();
            this.textBox1.Text = result.Result();




        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "√";
            var result = new MathOperation(this.textBox1.Text);
            
            this.textBox1.Text = result.Result();
            


        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "-";
            
        }

        private void Logger_Click(object sender, EventArgs e)
        {
            

        }
    }
}
