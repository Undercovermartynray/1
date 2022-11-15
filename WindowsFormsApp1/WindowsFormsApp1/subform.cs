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
    public partial class subform : Form
    {
        public subform()
        {
            InitializeComponent();
        }

        private void subform_Load(object sender, EventArgs e)
        {
            subform frm = new subform();
            frm.MdiParent = this;
            frm.Show();
            //string username = textBox1.Text;
            //string password = textBox2.Text;
            //string connString = @"Data source=.\sqlexpress;Initial Catalog=Myschool;Integrated Security=true";
            //Sqlconnection conn = new Sqlconnection(connString);
            //string sql=string.Format("select")
        }
    }
}
