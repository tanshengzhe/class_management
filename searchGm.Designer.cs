namespace class_management
{
    partial class searchGm
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
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.btn_SearchBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_teachername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Location = new System.Drawing.Point(78, 85);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(41, 12);
            this.lbl_teacher.TabIndex = 5;
            this.lbl_teacher.Text = "课程名";
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(140, 82);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(100, 21);
            this.txt_classname.TabIndex = 4;
            // 
            // btn_SearchBack
            // 
            this.btn_SearchBack.Location = new System.Drawing.Point(116, 168);
            this.btn_SearchBack.Name = "btn_SearchBack";
            this.btn_SearchBack.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchBack.TabIndex = 3;
            this.btn_SearchBack.Text = "检索";
            this.btn_SearchBack.UseVisualStyleBackColor = true;
            this.btn_SearchBack.Click += new System.EventHandler(this.btn_SearchBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "任课教师";
            // 
            // txt_teachername
            // 
            this.txt_teachername.Location = new System.Drawing.Point(140, 121);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(100, 21);
            this.txt_teachername.TabIndex = 6;
            // 
            // searchGm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.btn_SearchBack);
            this.Name = "searchGm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchGm";
            this.Load += new System.EventHandler(this.searchGm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_teacher;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Button btn_SearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_teachername;
    }
}