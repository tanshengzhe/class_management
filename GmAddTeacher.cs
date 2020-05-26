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
    public partial class GmAddTeacher : Form
    {
        public GmAddTeacher()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if ( txt_tchrpassword.Text.Trim() == ""||txt_teacherid.Text.Trim() ==""||txt_teachername.Text.Trim() =="")
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "insert into teacher values('{0}','{1}','{2}');";//向appointment中添加
                sql = string.Format(sql, txt_teacherid.Text,txt_teachername.Text,txt_tchrpassword.Text);

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
