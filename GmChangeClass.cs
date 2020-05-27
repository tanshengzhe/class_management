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
    public partial class GmChangeClass : Form
    {
        public string classid;
        public GmChangeClass()
        {
            InitializeComponent();
        }
        public GmChangeClass(string id,string name,string teacher,string std)
        {
            InitializeComponent();
            txt_teacherid.Text = id;
            txt_teachername.Text = name;
            txt_tchrpassword.Text = teacher;
            txt_stdQuatuty.Text = std;
            classid = id;

        }

        private void GmChangeClass_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_tchrpassword.Text.Trim() == "" || txt_teacherid.Text.Trim() == "" || txt_teachername.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空,修改失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "update class set class_id ='{0}',class_name='{1}',teacher_name='{2}',std_quatity='{3}' where class_id='{4}'";//向appointment中添加
                sql = string.Format(sql, txt_teacherid.Text, txt_teachername.Text, txt_tchrpassword.Text, txt_stdQuatuty.Text, classid);

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
