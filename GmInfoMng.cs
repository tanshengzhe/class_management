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
    public partial class GmInfoMng : Form
    {
        private void displaysortteacher(string name)
        {

            string sql = "select * from  teacher where teacher_name='{0}'";
            sql = string.Format(sql, name);
            //创建数据库操作类的对象
            Function fun = new Function();
            //执行对数据库表的查询操作
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];

            Dgv_Gm.DataSource = dt;
            Dgv_Gm.Refresh();

        }
        private void displaysortclass(string name)
        {

                string sql = "select * from  class where class_name='{0}'";
                sql = string.Format(sql, name);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Gm.DataSource = dt;
                Dgv_Gm.Refresh();
            
        }
        /// <summary>
        /// 筛选后显示
        /// </summary>
        /// <param name="readeridd"></param>
        private void displaysortorder(String readeridd, string classname,string teachername)
        {
            string sql="";

            if (classname == "" && teachername != "")
            {
                sql = "select * from  appointment where teacher_name='{0}' and  enable='占用'";
                sql = string.Format(sql, teachername);
            }
            else if (classname != "" && teachername == "")
            {
                sql = "select * from  appointment where class_name='{0}' and  enable='占用'";
                sql = string.Format(sql, classname);
            }
            else if (classname != "" && teachername != "")
            {
                 sql = "select * from  appointment where teacher_name='{0}' and class_name='{1}' and  enable='占用'";
                sql = string.Format(sql,  teachername, classname);
            }
            else
            {
                MessageBox.Show("不能全为空");
                return;
            }
            //创建数据库操作类的对象
            Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Gm.DataSource = dt;
                Dgv_Gm.Refresh();

            


        }
        public  void displaydgv()
        {
            string sql;
            if (GmSelection.order_flag==1)
            {
                 sql = "select * from  appointment where enable='占用' ";
            }
            else if(GmSelection.teacher_flag==1)
            {
                sql = "select * from  teacher ";
            }
            else
            {
                sql = "select * from  class ";
            }
            
            //创建数据库操作类的对象
            Function fun = new Function();
            //执行对数据库表的查询操作
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];

            Dgv_Gm.DataSource = dt;
            Dgv_Gm.Refresh();
        }
        public GmInfoMng()
        {
            InitializeComponent();
        }

        private void GmInfoMng_Load(object sender, EventArgs e)
        {
            displaydgv();//进入时更新列表
        }

        private void btn_GmBack_Click(object sender, EventArgs e)
        {
            GmSelection.order_flag = 0;
             GmSelection.class_flag = 0;
              GmSelection.teacher_flag = 0;
        GmSelection Frm_Gmsel = new GmSelection();
            Frm_Gmsel.Show();
            this.Hide();
    }

        private void btn_GmAdd_Click(object sender, EventArgs e)
        {
            if (GmSelection.order_flag==1)
            {
                PimAdd Frm_pimAdd = new PimAdd();
                Frm_pimAdd.Show();

            }
            else if(GmSelection.teacher_flag==1)
            {
                GmAddTeacher Frm_gmAddTeacher = new GmAddTeacher();
                Frm_gmAddTeacher.Show();
            }
            else
            {
                GmAddClass Frm_gmAddClass = new GmAddClass();
                Frm_gmAddClass.Show();
            }
        }

        private void btn_GmDelet_Click(object sender, EventArgs e)
        {
            int a = Dgv_Gm.CurrentRow.Index;
            string week;
            string day;
            string classtime;
            string teacherid;
            string classid;
            //if (GmSelection.order_flag == 1)
            //{
            //    week = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
            //    day = Dgv_Gm.Rows[a].Cells[1].Value.ToString();
            //    classtime = Dgv_Gm.Rows[a].Cells[2].Value.ToString();
            //}
            //else if(GmSelection.teacher_flag == 1)
            //{
            //    teacherid= Dgv_Gm.Rows[a].Cells[0].Value.ToString();
            //}
            //else
            //{
            //    classid= Dgv_Gm.Rows[a].Cells[0].Value.ToString();
            //}
            try
            {
                ////Add student information
                string sql ;

                sql = "update appointment set class_id='无',class_name='无',teacher_id='无',teacher_name='无',enable='0' where week='{0}' and day='{1}' and classtime='{2}'";

                if (GmSelection.order_flag == 1)
                {
                    week = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                    day = Dgv_Gm.Rows[a].Cells[1].Value.ToString();
                    classtime = Dgv_Gm.Rows[a].Cells[2].Value.ToString();
                    sql = "update appointment set class_id='无',class_name='无',teacher_id='无',teacher_name='无',enable='0' where week='{0}' and day='{1}' and classtime='{2}'";
                    sql = string.Format(sql, week, day, classtime);
                }
                else if (GmSelection.teacher_flag == 1)
                {
                    teacherid = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                    sql = "delete from teacher where teacher_id='{0}'";
                    sql = string.Format(sql,teacherid);
                }
                else
                {
                    classid = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                    sql = "delete from  class where class_id='{0}'";
                    sql = string.Format(sql,classid);
                }


                

                // Create Database Object Class
                Function fun = new Function();
                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                displaydgv();
            }
            catch
            {
                MessageBox.Show("用户名或书籍不存在，还书失败！");
            }
            finally
            {

            }
        }

        private void btn_frash_Click(object sender, EventArgs e)
        {
            displaydgv();
        }

        private void btn_GmChange_Click(object sender, EventArgs e)
        {
            
            int a = Dgv_Gm.CurrentRow.Index;
            string teacher_id;
            string teacher_name;
            string teacher_password;
            string class_id;
            string class_name;
            string class_teacher;
            string class_std;
            if (GmSelection.teacher_flag == 1)
            {
                teacher_id = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                teacher_name = Dgv_Gm.Rows[a].Cells[1].Value.ToString();
                teacher_password = Dgv_Gm.Rows[a].Cells[2].Value.ToString();
                GmChangeTeacher FrmgmChangeTeacher = new GmChangeTeacher(teacher_id, teacher_name, teacher_password);
                FrmgmChangeTeacher.Show();
                
            }
            else if(GmSelection.class_flag ==1)
            {
                class_id = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                class_name = Dgv_Gm.Rows[a].Cells[1].Value.ToString();
                class_teacher = Dgv_Gm.Rows[a].Cells[2].Value.ToString();
                class_std= Dgv_Gm.Rows[a].Cells[3].Value.ToString();
                GmChangeClass Frm_gmChangeClass = new GmChangeClass(class_id, class_name, class_teacher, class_std);
                Frm_gmChangeClass.Show();

            }
            else
            {
                GmChangeAppcs Frm_gmChangeAppcs = new GmChangeAppcs() ;
                Frm_gmChangeAppcs.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Dgv_Gm.CurrentRow.Index;
            string week;
            string day;
            string classtime;
            string teacherid;
            string classid;
            string sql;
            if (GmSelection.order_flag == 1)
            {
                week = Dgv_Gm.Rows[a].Cells[0].Value.ToString();
                day = Dgv_Gm.Rows[a].Cells[1].Value.ToString();
                classtime = Dgv_Gm.Rows[a].Cells[2].Value.ToString();
                sql = "update appointment set class_id='无',class_name='无',teacher_id='无',teacher_name='无',enable='1' where week='{0}' and day='{1}' and classtime='{2}'";
                sql = string.Format(sql, week, day, classtime);
            }
        }

        private void cmb_Gmweek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (GmSelection.order_flag == 1)
            {
                searchGm f2 = new searchGm();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    displaysortorder(logon.idnum, f2.classname, f2.teachername);
                    f2.Close();

                }
            }
            else if(GmSelection.teacher_flag==1)
            {
                searchteacher f2 = new searchteacher();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    displaysortteacher(f2.teachername);
                    f2.Close();

                }
            }
            else
            {
                search f2 = new search();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    displaysortclass(f2.classname);
                    f2.Close();

                }
            }
        }
    }
}
