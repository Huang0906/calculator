using System;

namespace test1
{
    public partial class Form1 : Form
    {
        string mathematical = null;
        string beforeValue = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            float a = 0;
            a = (float)(value * (-1.0));
            textBox1.Text=a.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            
        }
        private void button12_Click(object sender, EventArgs e)
        {
            
        }
        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
        
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString().Substring(0, textBox1.Text.Length - 1);
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            float GetBeforeValue = float.Parse(beforeValue);
            float GetAfterValue = float.Parse(textBox1.Text);
            float Result = 0;

            switch (mathematical)
            {
                
                case "+":
                    Result = GetBeforeValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforeValue - GetAfterValue;
                    break;
                case "*":
                    Result = GetBeforeValue * GetAfterValue;
                    break;
                case "/":
                    Result = GetBeforeValue / GetAfterValue;
                    break;
                
            }

            textBox1.Text = Result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button buttonMathematical = sender as Button;
            mathematical = buttonMathematical.Text; //記錄所點擊的運算式
            beforeValue = textBox1.Text; //記錄使用者輸入前一個值的內容
            textBox1.Text = "";

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = buttonNumber.Text;
            }
            else
            {
                textBox1.Text += buttonNumber.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double value = Convert.ToInt32(textBox1.Text);
            double a=0;
            a=value*value;
            textBox1.Text=a.ToString();
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);
            double a = System.Math.Sqrt(value);
            textBox1.Text = a.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double value = Convert.ToInt32(textBox1.Text);
            double a ;
            a=(1/value);
            textBox1.Text = a.ToString();
        }
    }
}
