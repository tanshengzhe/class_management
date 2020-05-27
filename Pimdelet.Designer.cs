namespace class_management
{
    partial class Pimdelet
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PdDelet = new System.Windows.Forms.Button();
            this.bnt_PdBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "是否删除预约？";
            // 
            // btn_PdDelet
            // 
            this.btn_PdDelet.Location = new System.Drawing.Point(94, 167);
            this.btn_PdDelet.Name = "btn_PdDelet";
            this.btn_PdDelet.Size = new System.Drawing.Size(75, 23);
            this.btn_PdDelet.TabIndex = 1;
            this.btn_PdDelet.Text = "button1";
            this.btn_PdDelet.UseVisualStyleBackColor = true;
            // 
            // bnt_PdBack
            // 
            this.bnt_PdBack.Location = new System.Drawing.Point(239, 167);
            this.bnt_PdBack.Name = "bnt_PdBack";
            this.bnt_PdBack.Size = new System.Drawing.Size(75, 23);
            this.bnt_PdBack.TabIndex = 2;
            this.bnt_PdBack.Text = "button2";
            this.bnt_PdBack.UseVisualStyleBackColor = true;
            // 
            // Pimdelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 248);
            this.Controls.Add(this.bnt_PdBack);
            this.Controls.Add(this.btn_PdDelet);
            this.Controls.Add(this.label1);
            this.Name = "Pimdelet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PdDelet;
        private System.Windows.Forms.Button bnt_PdBack;
    }
}