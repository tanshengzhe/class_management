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
    public partial class PimChange : Form
    {
        public PimChange()
        {
            InitializeComponent();
        }

        private void lbl_PcTeacher_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PcYes_Click(object sender, EventArgs e)
        {
            if (txt_Pcclasschange.Text.Trim() == "" || txt_StdQuatity.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空,修改失败！");
            }
            try
            {
                string sql = "update appointment set class_name='{0}' where week='{1} 'and day='{2}'and classtime='{3}'";//向appointment中添加
                sql = string.Format(sql, txt_Pcclasschange.Text,PersonalInfoManagment.prs_week,PersonalInfoManagment.prs_day,PersonalInfoManagment.prs_classtime);
                Function fun = new Function();
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
        }
    }
}
