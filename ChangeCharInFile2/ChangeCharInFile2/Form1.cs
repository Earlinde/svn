using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ChangeCharInFile2
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
        /// <summary>
        /// 将文件读入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader readin = new StreamReader(@"test.txt",Encoding.Default);//这里的txt在bin/debug文件夹下面
            string instr = readin.ReadToEnd();
            textBox3.Text = instr;
            readin.Close();
        }
        /// <summary>
        /// 将修改后的文本写进文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writein = new StreamWriter(@"test.txt");
            string outstr = textBox3.Text;
            writein.WriteLine(outstr);
            writein.Close();

        }
        /// <summary>
        /// 修改文本内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string findstr = textBox1.Text;
            string replstr = textBox2.Text;
            int start;

            start = textBox3.Text.IndexOf(textBox1.Text);//这里判断有没有字符串，没有,返回-1
            if (start >= 0)
            {
                start = start + 1;
                textBox3.Focus();
                textBox3.Text = textBox3.Text.Replace(findstr, replstr);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
