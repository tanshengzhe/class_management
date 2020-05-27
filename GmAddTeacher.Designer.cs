namespace class_management
{
    partial class GmAddTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_teacherpaddword = new System.Windows.Forms.Label();
            this.txt_tchrpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teacherid = new System.Windows.Forms.TextBox();
            this.lbl_teacherid = new System.Windows.Forms.Label();
            this.txt_teachername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(59, 309);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "添加";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(212, 309);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_teacherpaddword
            // 
            this.lbl_teacherpaddword.AutoSize = true;
            this.lbl_teacherpaddword.Location = new System.Drawing.Point(64, 237);
            this.lbl_teacherpaddword.Name = "lbl_teacherpaddword";
            this.lbl_teacherpaddword.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherpaddword.TabIndex = 2;
            this.lbl_teacherpaddword.Text = "教师密码";
            // 
            // txt_tchrpassword
            // 
            this.txt_tchrpassword.Location = new System.Drawing.Point(146, 234);
            this.txt_tchrpassword.Name = "txt_tchrpassword";
            this.txt_tchrpassword.Size = new System.Drawing.Size(100, 21);
            this.txt_tchrpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入添加信息";
            // 
            // txt_teacherid
            // 
            this.txt_teacherid.Location = new System.Drawing.Point(146, 133);
            this.txt_teacherid.Name = "txt_teacherid";
            this.txt_teacherid.Size = new System.Drawing.Size(100, 21);
            this.txt_teacherid.TabIndex = 6;
            // 
            // lbl_teacherid
            // 
            this.lbl_teacherid.AutoSize = true;
            this.lbl_teacherid.Location = new System.Drawing.Point(64, 136);
            this.lbl_teacherid.Name = "lbl_teacherid";
            this.lbl_teacherid.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherid.TabIndex = 5;
            this.lbl_teacherid.Text = "教师工号";
            // 
            // txt_teachername
            // 
            this.txt_teachername.Location = new System.Drawing.Point(146, 183);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(100, 21);
            this.txt_teachername.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "教师姓名";
            // 
            // GmAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 357);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teacherid);
            this.Controls.Add(this.lbl_teacherid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tchrpassword);
            this.Controls.Add(this.lbl_teacherpaddword);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_change);
            this.Name = "GmAddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GmAddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_teacherpaddword;
        private System.Windows.Forms.TextBox txt_tchrpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teacherid;
        private System.Windows.Forms.Label lbl_teacherid;
        private System.Windows.Forms.TextBox txt_teachername;
        private System.Windows.Forms.Label label1;
    }
}