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
    public partial class PimChangTeacher : Form
    {
        public PimChangTeacher()
        {
            InitializeComponent();
        }

        private void PimChangTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_tchrpassword.Text.Trim() == "" )
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "update teacher set teacher_password='{0}' where teacher_id='{1}'";//向appointment中添加
                sql = string.Format(sql,txt_tchrpassword.Text, logon.idnum);

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
