namespace class_management
{
    partial class PimAdd
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
            this.Dgv_PA = new System.Windows.Forms.DataGridView();
            this.cmb_PimAddWeek = new System.Windows.Forms.ComboBox();
            this.bnt_PaBack = new System.Windows.Forms.Button();
            this.bnt_PaAdd = new System.Windows.Forms.Button();
            this.lbl_PaTitle2 = new System.Windows.Forms.Label();
            this.cmb_PimAddday = new System.Windows.Forms.ComboBox();
            this.lbl_PaTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgv_class = new System.Windows.Forms.DataGridView();
            this.btn_frash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_class)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_PA
            // 
            this.Dgv_PA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_PA.Location = new System.Drawing.Point(633, 96);
            this.Dgv_PA.Name = "Dgv_PA";
            this.Dgv_PA.RowTemplate.Height = 23;
            this.Dgv_PA.Size = new System.Drawing.Size(368, 222);
            this.Dgv_PA.TabIndex = 0;
            // 
            // cmb_PimAddWeek
            // 
            this.cmb_PimAddWeek.FormattingEnabled = true;
            this.cmb_PimAddWeek.Location = new System.Drawing.Point(663, 324);
            this.cmb_PimAddWeek.Name = "cmb_PimAddWeek";
            this.cmb_PimAddWeek.Size = new System.Drawing.Size(121, 20);
            this.cmb_PimAddWeek.TabIndex = 1;
            this.cmb_PimAddWeek.Text = "第二周";
            this.cmb_PimAddWeek.SelectedIndexChanged += new System.EventHandler(this.cmb_PimAddWeek_SelectedIndexChanged);
            // 
            // bnt_PaBack
            // 
            this.bnt_PaBack.Location = new System.Drawing.Point(578, 381);
            this.bnt_PaBack.Name = "bnt_PaBack";
            this.bnt_PaBack.Size = new System.Drawing.Size(110, 43);
            this.bnt_PaBack.TabIndex = 5;
            this.bnt_PaBack.Text = "返回";
            this.bnt_PaBack.UseVisualStyleBackColor = true;
            this.bnt_PaBack.Click += new System.EventHandler(this.bnt_PaBack_Click);
            // 
            // bnt_PaAdd
            // 
            this.bnt_PaAdd.Location = new System.Drawing.Point(362, 381);
            this.bnt_PaAdd.Name = "bnt_PaAdd";
            this.bnt_PaAdd.Size = new System.Drawing.Size(110, 43);
            this.bnt_PaAdd.TabIndex = 6;
            this.bnt_PaAdd.Text = "添加";
            this.bnt_PaAdd.UseVisualStyleBackColor = true;
            this.bnt_PaAdd.Click += new System.EventHandler(this.bnt_PaAdd_Click);
            // 
            // lbl_PaTitle2
            // 
            this.lbl_PaTitle2.AutoSize = true;
            this.lbl_PaTitle2.Location = new System.Drawing.Point(775, 72);
            this.lbl_PaTitle2.Name = "lbl_PaTitle2";
            this.lbl_PaTitle2.Size = new System.Drawing.Size(77, 12);
            this.lbl_PaTitle2.TabIndex = 7;
            this.lbl_PaTitle2.Text = "当前可选时间";
            this.lbl_PaTitle2.Click += new System.EventHandler(this.lbl_PaTitle2_Click);
            // 
            // cmb_PimAddday
            // 
            this.cmb_PimAddday.FormattingEnabled = true;
            this.cmb_PimAddday.Location = new System.Drawing.Point(846, 324);
            this.cmb_PimAddday.Name = "cmb_PimAddday";
            this.cmb_PimAddday.Size = new System.Drawing.Size(121, 20);
            this.cmb_PimAddday.TabIndex = 8;
            this.cmb_PimAddday.Text = "星期一";
            this.cmb_PimAddday.SelectedIndexChanged += new System.EventHandler(this.cmb_PimAddday_SelectedIndexChanged);
            // 
            // lbl_PaTitle
            // 
            this.lbl_PaTitle.AutoSize = true;
            this.lbl_PaTitle.Location = new System.Drawing.Point(129, 72);
            this.lbl_PaTitle.Name = "lbl_PaTitle";
            this.lbl_PaTitle.Size = new System.Drawing.Size(113, 12);
            this.lbl_PaTitle.TabIndex = 4;
            this.lbl_PaTitle.Text = "选择您将预约的课程";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "需要添加新课程？";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgv_class
            // 
            this.Dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_class.Location = new System.Drawing.Point(26, 96);
            this.Dgv_class.Name = "Dgv_class";
            this.Dgv_class.RowTemplate.Height = 23;
            this.Dgv_class.Size = new System.Drawing.Size(419, 222);
            this.Dgv_class.TabIndex = 11;
            // 
            // btn_frash
            // 
            this.btn_frash.Location = new System.Drawing.Point(479, 72);
            this.btn_frash.Name = "btn_frash";
            this.btn_frash.Size = new System.Drawing.Size(75, 23);
            this.btn_frash.TabIndex = 13;
            this.btn_frash.Text = "刷新";
            this.btn_frash.UseVisualStyleBackColor = true;
            this.btn_frash.Click += new System.EventHandler(this.btn_frash_Click);
            // 
            // PimAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.btn_frash);
            this.Controls.Add(this.Dgv_class);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_PimAddday);
            this.Controls.Add(this.lbl_PaTitle2);
            this.Controls.Add(this.bnt_PaAdd);
            this.Controls.Add(this.bnt_PaBack);
            this.Controls.Add(this.lbl_PaTitle);
            this.Controls.Add(this.cmb_PimAddWeek);
            this.Controls.Add(this.Dgv_PA);
            this.Name = "PimAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.PimAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_PA;
        private System.Windows.Forms.ComboBox cmb_PimAddWeek;
        private System.Windows.Forms.Button bnt_PaBack;
        private System.Windows.Forms.Button bnt_PaAdd;
        private System.Windows.Forms.Label lbl_PaTitle2;
        private System.Windows.Forms.ComboBox cmb_PimAddday;
        private System.Windows.Forms.Label lbl_PaTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgv_class;
        private System.Windows.Forms.Button btn_frash;
    }
}