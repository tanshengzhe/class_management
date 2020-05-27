using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_management
{
    public partial class GmAddClass : Form
    {
        public GmAddClass()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_teacherid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_teacherid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tchrpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_teacherpaddword_Click(object sender, EventArgs e)
        {

        }

        private void txt_teachername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_tchrpassword.Text.Trim() == "" || txt_teacherid.Text.Trim() == "" || txt_teachername.Text.Trim() == ""||txt_stdQuatuty.Text.Trim()=="")
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "insert into class values('{0}','{1}','{2}','{3}');";//向appointment中添加
                sql = string.Format(sql, txt_teacherid.Text, txt_teachername.Text, txt_tchrpassword.Text,txt_stdQuatuty.Text);

                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            catch { }
            finally { }
            this.Hide();
        }
    }
}
