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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
            timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Ava");
                    listBox1.Items.Add("Bella");
                    listBox1.Items.Add("Carol");
                    listBox1.Items.Add("Diana");
                    listBox1.Items.Add("Eileen");
                    break;
                case 1:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("kiana");
                    listBox1.Items.Add("mei");
                    listBox1.Items.Add("bronia");
                    listBox1.Items.Add("himeiko");
                    listBox1.Items.Add("terrisa");
                    break;
                case 2:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("seele");
                    listBox1.Items.Add("sin");
                    listBox1.Items.Add("fuka");
                    break;
                              }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ava = "";
            if (radioButton1.Checked)
                ava = radioButton1.Text;
            else
                ava = radioButton2.Text;
            string dept = comboBox1.SelectedItem.ToString();
           string spec = listBox1.SelectedItem.ToString();
            string mainman = "";
            if (checkBox1.Checked) mainman += checkBox1.Text;
            if (checkBox2.Checked) mainman += "、" + checkBox2.Text;
            if (checkBox3.Checked) mainman += "、" + checkBox3.Text;
            if (checkBox4.Checked) mainman += "、" + checkBox4.Text;
            if (checkBox5.Checked) mainman += "、" + checkBox5.Text;
            if (checkBox6.Checked) mainman += "、" + checkBox6.Text;
            string info = "" + textBox1.Text+textBox2.Text;
            info += "\n收支类型为:" + ava;
            info += "\n日期为:" + dateTimePicker1.Value.ToShortDateString();
            info += "\n你的类别和项目是:" + dept+ spec;
            info += "\n收支人是:" + mainman;
            info += "\n金额是:" + numericUpDown1.TextAlign;
            MessageBox.Show(info, "信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Left >= this.Width)
            {
                label9.Left = 0;
            }
            label9.Left += 1;
        }
    }
}
