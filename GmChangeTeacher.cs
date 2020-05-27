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
    public partial class GmChangeTeacher : Form
    {
        public string teacherid;
        public GmChangeTeacher()
        {
            InitializeComponent();
        }
        public GmChangeTeacher(string id,string name,string password)
        {
            InitializeComponent();
            txt_teacherid.Text = id;
            txt_teachername.Text = name;
            txt_tchrpassword.Text = password;
            teacherid = id;
        }

        private void GmChangeTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_tchrpassword.Text.Trim() == "" || txt_teacherid.Text.Trim() == "" || txt_teachername.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "update teacher set teacher_id ='{0}',teacher_name='{1}',teacher_password='{2}' where teacher_id='{3}'";//向appointment中添加
                sql = string.Format(sql, txt_teacherid.Text, txt_teachername.Text, txt_tchrpassword.Text,teacherid);

                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }

            }
            catch { }
            finally { }
            this.Hide();
        }
    }
}
