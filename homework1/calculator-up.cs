using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form2 : Form
    {
        private string num1, num2;
        private string str;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumClick(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(str))
            {
                num1 = num1 + button.Text;
            }
            else
            {
                num2 = num2 + button.Text;
            }
            textRes.Text = textRes.Text + button.Text;
        }

        private void StrClick(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (string.IsNullOrEmpty(num2))
            {
                MessageBox.Show("请先输入数字");
                return;
            }
            str = button.Text;
            textRes.Text = textRes.Text + button.Text;
        }

        private void GetClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(str)|| string.IsNullOrEmpty(num1)|| string.IsNullOrEmpty(num2))
            {
                MessageBox.Show("请输入正确内容");
                return;
            }
            textRes.Text = textRes.Text + "=";
            switch (str)
            {
                case "+": textRes.Text = textRes.Text + (Int32.Parse(num1) + Int32.Parse(num2));break;
                case "-": textRes.Text = textRes.Text + (Int32.Parse(num1) - Int32.Parse(num2)); break;
                case "*": textRes.Text = textRes.Text + (Int32.Parse(num1) * Int32.Parse(num2)); break;
                case "/": if (num2 == "0") { MessageBox.Show("除数不能为零"); }
                    else { textRes.Text = textRes.Text + (Int32.Parse(num1) / Int32.Parse(num2)); }
                    break;
            }
        }



        private void ClearClick(object sender, EventArgs e)
        {
            textRes.Text = "";
            num1 = "";
            num2 = "";
            str = "";
        }
    }
}
