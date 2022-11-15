using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        string sname;
        string classfiction;
        string required;
        public Form4()
        {
          
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else 
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex ==1)
            {
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    sname = textBox1.Text;
                    classfiction = comboBox1.SelectedIndex.ToString();
                    required = radioButton1.Checked ? "收入" : "支出";
                    string message = string.Format("项目名称：{0}\n所属类别：{1}\n类别；{2}\n", sname, classfiction, required);
                    label4.Text = message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
