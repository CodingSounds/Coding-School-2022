using Calculator;

namespace Last6
{
    public partial class Form1 : Form
    {
        Logger Logger1 { get; set; }
        
        public Form1()
        {
            InitializeComponent();
              Logger1=new Logger();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 x = new Class1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "^";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            StringNumber x = new StringNumber(this.textBox1.Text);
            
            this.textBox1.Text += "x";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                
                decimal number = Convert.ToDecimal(this.textBox1.Text);

                var rootObj = new Root(number,number);



                this.textBox2.Text += "\r\n";
                this.textBox2.Text += "√"+ this.textBox1.Text+ Convert.ToString(rootObj.Sqr());

                this.textBox1.Text = Convert.ToString(rootObj.Sqr());
                
            }
            catch (Exception ex)
            {
                this.textBox2.Text += "\r\n";
                this.textBox2.Text += ex.Message;


                Logger1.Insert(ex.Message);


                
            }

            
            

            

            

            
            
            


        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ":";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text += "=";
                var mathOperation = new MathOperation(this.textBox1.Text);



                if (mathOperation != null)
                {
                    Logger1.Insert(this.textBox1.Text + mathOperation.Result());
                    this.textBox2.Text += this.textBox1.Text + mathOperation.Result();
                    this.textBox2.Text += "\r\n";
                    this.textBox1.Text = mathOperation.Result();
                }
                else
                {
                    Logger1.Insert("Wrong insert");
                    this.textBox2.Text += "\r\n";
                    this.textBox2.Text += "Wrong insert";
                    this.textBox1.Text = string.Empty;


                }


                //this.Logger.Text = result.Result();
               



            }
            catch (Exception ex)
            {

                Logger1.Insert(ex.Message);

                this.textBox2.Text += "\r\n";

                this.textBox2.Text += ex.Message;
            }
            

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
    }
}