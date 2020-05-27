namespace class_management
{
    partial class searchteacher
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
            this.SuspendLayout();
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Location = new System.Drawing.Point(39, 65);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(41, 12);
            this.lbl_teacher.TabIndex = 5;
            this.lbl_teacher.Text = "教师名";
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(101, 62);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(100, 21);
            this.txt_classname.TabIndex = 4;
            // 
            // btn_SearchBack
            // 
            this.btn_SearchBack.Location = new System.Drawing.Point(74, 110);
            this.btn_SearchBack.Name = "btn_SearchBack";
            this.btn_SearchBack.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchBack.TabIndex = 3;
            this.btn_SearchBack.Text = "检索";
            this.btn_SearchBack.UseVisualStyleBackColor = true;
            this.btn_SearchBack.Click += new System.EventHandler(this.btn_SearchBack_Click);
            // 
            // searchteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 178);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.btn_SearchBack);
            this.Name = "searchteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchteacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_teacher;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Button btn_SearchBack;
    }
}