using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NANO_CALCULATOR
{
    public partial class Form1 : Form
    {
        double a, b;
        int op;
        bool sign = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 4;
            label1.Text = a.ToString();
            label3.Text = "/";
            sign = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 1;
            label1.Text = a.ToString();
            label3.Text = "+";
            sign = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 2;
            label1.Text = a.ToString();
            label3.Text = "-";
            sign = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 3;
            label1.Text = a.ToString();
            label3.Text = "*";
            sign = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }  
            double c = float.Parse(textBox1.Text);
            calculate(op,a,c);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            label3.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 5;
            label1.Text ="sin(" + a.ToString() + ")";
            sign = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 6;
            label1.Text = "cos(" + a.ToString() + ")";
            sign = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = 7;
            label1.Text = "ln(" + a.ToString() + ")";
            sign = true;
        }

        public string calculate(int op, double a, double c)
        {
            switch (op)
            {
                case 1:
                    b = a + c;
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 2:
                    b = a - c;
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 3:
                    b = a * c;
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 4:
                    b = a / c;
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 5:
                    a *= (Math.PI / 180.0);
                    b = Math.Sin(a);
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 6:
                    a *= (Math.PI / 180.0);
                    b = Math.Cos(a);
                    textBox2.Text = b.ToString();
                    return b.ToString();
                case 7:
                        b = Math.Log(a);
                        textBox2.Text = b.ToString();
                    return b.ToString();
                default:
                    return "0";
            }
        }
    }
}
