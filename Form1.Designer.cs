namespace class_management
{
    partial class logon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btnLogin_in = new System.Windows.Forms.Button();
            this.bnt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(95, 138);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(29, 12);
            this.lblpassword.TabIndex = 17;
            this.lblpassword.Text = "密码";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(95, 104);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(29, 12);
            this.lblusername.TabIndex = 16;
            this.lblusername.Text = "账号";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 21);
            this.txtPassword.TabIndex = 15;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(165, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 21);
            this.txtusername.TabIndex = 14;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(-3, 35);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(504, 26);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "实验室预约系统";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin_in
            // 
            this.btnLogin_in.Location = new System.Drawing.Point(180, 169);
            this.btnLogin_in.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin_in.Name = "btnLogin_in";
            this.btnLogin_in.Size = new System.Drawing.Size(60, 32);
            this.btnLogin_in.TabIndex = 10;
            this.btnLogin_in.Text = "登陆";
            this.btnLogin_in.UseVisualStyleBackColor = true;
            this.btnLogin_in.Click += new System.EventHandler(this.btnLogin_in_Click);
            // 
            // bnt_login
            // 
            this.bnt_login.Location = new System.Drawing.Point(273, 169);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(60, 32);
            this.bnt_login.TabIndex = 19;
            this.bnt_login.Text = "注册";
            this.bnt_login.UseVisualStyleBackColor = true;
            this.bnt_login.Click += new System.EventHandler(this.bnt_login_Click);
            // 
            // logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.bnt_login);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btnLogin_in);
            this.Name = "logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.logon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btnLogin_in;
        private System.Windows.Forms.Button bnt_login;
    }
}

