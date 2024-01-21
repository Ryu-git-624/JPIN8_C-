using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingApp
{
    public partial class Form1 : Form
    {
        private static readonly int count = 8;
        private static int tryCount = 0;
        private Examination examination;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            examination = new Examination(count);
            QuestionValueLabel.Text = examination.getList()[0].getValue();
            QuestionCount.Text = "問題数：" + count.ToString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Question question = new Question(QuestionValueLabel.Text);
            if (question.isMatch(textBox1.Text))
            {
                tryCount++;
                if (tryCount == count)
                {
                    MessageBox.Show("クリア！");
                    Application.Exit();
                }
                else
                {
                    QuestionValueLabel.Text = examination.getList()[tryCount].getValue();
                    textBox1.Text = "";
                }
            }   
        }

        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

                Question question = new Question(QuestionValueLabel.Text);
                if (question.isMatch(textBox1.Text))
                {
                    tryCount++;
                    Counter.Text = "正解数：" + tryCount.ToString();
                    if (tryCount == count)
                    {
                        MessageBox.Show("クリア！");
                        Application.Exit();
                    }
                    else
                    {
                        QuestionValueLabel.Text = examination.getList()[tryCount].getValue();
                        textBox1.Text = "";
                    }
                }
                else
                {
                    textBox1.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter！");
        }
    }
}
