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
            this.txt_teacher = new System.Windows.Forms.TextBox();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SearchBack
            // 
            this.btn_SearchBack.Location = new System.Drawing.Point(98, 285);
            this.btn_SearchBack.Name = "btn_SearchBack";
            this.btn_SearchBack.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchBack.TabIndex = 0;
            this.btn_SearchBack.Text = "button1";
            this.btn_SearchBack.UseVisualStyleBackColor = true;
            // 
            // txt_teacher
            // 
            this.txt_teacher.Location = new System.Drawing.Point(122, 72);
            this.txt_teacher.Name = "txt_teacher";
            this.txt_teacher.Size = new System.Drawing.Size(100, 21);
            this.txt_teacher.TabIndex = 1;
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Location = new System.Drawing.Point(60, 75);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(41, 12);
            this.lbl_teacher.TabIndex = 2;
            this.lbl_teacher.Text = "label1";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 347);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.txt_teacher);
            this.Controls.Add(this.btn_SearchBack);
            this.Name = "search";
            this.Text = "信息查找";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchBack;
        private System.Windows.Forms.TextBox txt_teacher;
        private System.Windows.Forms.Label lbl_teacher;
    }
}