﻿using System;
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
    public partial class search : Form
    {
        public string classname;
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void btn_SearchBack_Click(object sender, EventArgs e)
        {
            classname = txt_classname.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
