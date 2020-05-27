namespace class_management
{
    partial class search
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
            this.btn_SearchBack = new System.Windows.Forms.Button();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SearchBack
            // 
            this.btn_SearchBack.Location = new System.Drawing.Point(72, 111);
            this.btn_SearchBack.Name = "btn_SearchBack";
            this.btn_SearchBack.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchBack.TabIndex = 0;
            this.btn_SearchBack.Text = "检索";
            this.btn_SearchBack.UseVisualStyleBackColor = true;
            this.btn_SearchBack.Click += new System.EventHandler(this.btn_SearchBack_Click);
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(99, 63);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(100, 21);
            this.txt_classname.TabIndex = 1;
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Location = new System.Drawing.Point(37, 66);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(41, 12);
            this.lbl_teacher.TabIndex = 2;
            this.lbl_teacher.Text = "课程名";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 178);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.btn_SearchBack);
            this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息查找";
            this.Load += new System.EventHandler(this.search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchBack;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Label lbl_teacher;
    }
}