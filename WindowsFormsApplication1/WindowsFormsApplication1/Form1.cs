using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string str = "";
            textBox3.Text = str;
        }
        int start = 0;
        int count = 0;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击按钮1查找并替换字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string findstr = textBox1.Text;
            string replstr = textBox2.Text;

            if (start >= textBox3.Text.Length)
            {
                start = 0;
            }
            else
            {
                start = textBox3.Text.IndexOf(textBox1.Text);//这里判断有没有字符串，没有,返回-1
                if(start >= 0)
                {
                    start = start + 1;
                    textBox3.Focus();
                    textBox3.Text = textBox3.Text.Replace(findstr,replstr);
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
