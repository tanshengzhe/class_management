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
    public partial class GmChangeAppcs : Form
    {
        public GmChangeAppcs()
        {
            InitializeComponent();
        }

        private void GmChangeAppcs_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改成功！");
            this.Hide();
        }
    }
}
