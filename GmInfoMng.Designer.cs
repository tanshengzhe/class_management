namespace class_management
{
    partial class GmInfoMng
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
            this.btn_GmBack = new System.Windows.Forms.Button();
            this.cmb_Gmweek = new System.Windows.Forms.ComboBox();
            this.Dgv_Gm = new System.Windows.Forms.DataGridView();
            this.btn_GmSort = new System.Windows.Forms.Button();
            this.btn_GmDelet = new System.Windows.Forms.Button();
            this.btn_GmChange = new System.Windows.Forms.Button();
            this.btn_GmAdd = new System.Windows.Forms.Button();
            this.btn_frash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GmBack
            // 
            this.btn_GmBack.Location = new System.Drawing.Point(311, 344);
            this.btn_GmBack.Name = "btn_GmBack";
            this.btn_GmBack.Size = new System.Drawing.Size(98, 42);
            this.btn_GmBack.TabIndex = 15;
            this.btn_GmBack.Text = "返回";
            this.btn_GmBack.UseVisualStyleBackColor = true;
            this.btn_GmBack.Click += new System.EventHandler(this.btn_GmBack_Click);
            // 
            // cmb_Gmweek
            // 
            this.cmb_Gmweek.FormattingEnabled = true;
            this.cmb_Gmweek.Location = new System.Drawing.Point(432, 311);
            this.cmb_Gmweek.Name = "cmb_Gmweek";
            this.cmb_Gmweek.Size = new System.Drawing.Size(82, 20);
            this.cmb_Gmweek.TabIndex = 14;
            // 
            // Dgv_Gm
            // 
            this.Dgv_Gm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Gm.Location = new System.Drawing.Point(271, 90);
            this.Dgv_Gm.Name = "Dgv_Gm";
            this.Dgv_Gm.RowTemplate.Height = 23;
            this.Dgv_Gm.Size = new System.Drawing.Size(390, 215);
            this.Dgv_Gm.TabIndex = 13;
            // 
            // btn_GmSort
            // 
            this.btn_GmSort.Location = new System.Drawing.Point(271, 61);
            this.btn_GmSort.Name = "btn_GmSort";
            this.btn_GmSort.Size = new System.Drawing.Size(45, 23);
            this.btn_GmSort.TabIndex = 12;
            this.btn_GmSort.Text = "筛选";
            this.btn_GmSort.UseVisualStyleBackColor = true;
            // 
            // btn_GmDelet
            // 
            this.btn_GmDelet.Location = new System.Drawing.Point(67, 275);
            this.btn_GmDelet.Name = "btn_GmDelet";
            this.btn_GmDelet.Size = new System.Drawing.Size(75, 23);
            this.btn_GmDelet.TabIndex = 10;
            this.btn_GmDelet.Text = "删除";
            this.btn_GmDelet.UseVisualStyleBackColor = true;
            this.btn_GmDelet.Click += new System.EventHandler(this.btn_GmDelet_Click);
            // 
            // btn_GmChange
            // 
            this.btn_GmChange.Location = new System.Drawing.Point(67, 182);
            this.btn_GmChange.Name = "btn_GmChange";
            this.btn_GmChange.Size = new System.Drawing.Size(75, 23);
            this.btn_GmChange.TabIndex = 9;
            this.btn_GmChange.Text = "修改";
            this.btn_GmChange.UseVisualStyleBackColor = true;
            this.btn_GmChange.Click += new System.EventHandler(this.btn_GmChange_Click);
            // 
            // btn_GmAdd
            // 
            this.btn_GmAdd.Location = new System.Drawing.Point(67, 90);
            this.btn_GmAdd.Name = "btn_GmAdd";
            this.btn_GmAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_GmAdd.TabIndex = 8;
            this.btn_GmAdd.Text = "添加";
            this.btn_GmAdd.UseVisualStyleBackColor = true;
            this.btn_GmAdd.Click += new System.EventHandler(this.btn_GmAdd_Click);
            // 
            // btn_frash
            // 
            this.btn_frash.Location = new System.Drawing.Point(616, 61);
            this.btn_frash.Name = "btn_frash";
            this.btn_frash.Size = new System.Drawing.Size(45, 23);
            this.btn_frash.TabIndex = 16;
            this.btn_frash.Text = "刷新";
            this.btn_frash.UseVisualStyleBackColor = true;
            this.btn_frash.Click += new System.EventHandler(this.btn_frash_Click);
            // 
            // GmInfoMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.btn_frash);
            this.Controls.Add(this.btn_GmBack);
            this.Controls.Add(this.cmb_Gmweek);
            this.Controls.Add(this.Dgv_Gm);
            this.Controls.Add(this.btn_GmSort);
            this.Controls.Add(this.btn_GmDelet);
            this.Controls.Add(this.btn_GmChange);
            this.Controls.Add(this.btn_GmAdd);
            this.Name = "GmInfoMng";
            this.Text = "信息管理";
            this.Load += new System.EventHandler(this.GmInfoMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GmBack;
        private System.Windows.Forms.ComboBox cmb_Gmweek;
        private System.Windows.Forms.DataGridView Dgv_Gm;
        private System.Windows.Forms.Button btn_GmSort;
        private System.Windows.Forms.Button btn_GmDelet;
        private System.Windows.Forms.Button btn_GmChange;
        private System.Windows.Forms.Button btn_GmAdd;
        private System.Windows.Forms.Button btn_frash;
    }
}