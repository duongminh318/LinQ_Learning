namespace HocFindAll
{
    partial class Form1
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnTaoDS = new System.Windows.Forms.Button();
            this.lstGoc = new System.Windows.Forms.ListBox();
            this.btnLocChan = new System.Windows.Forms.Button();
            this.lstChan = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvSanPhamGoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lvSanPhamTim = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(52, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(52, 50);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(100, 38);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstGoc
            // 
            this.lstGoc.FormattingEnabled = true;
            this.lstGoc.ItemHeight = 25;
            this.lstGoc.Location = new System.Drawing.Point(176, 12);
            this.lstGoc.Name = "lstGoc";
            this.lstGoc.Size = new System.Drawing.Size(169, 229);
            this.lstGoc.TabIndex = 3;
            // 
            // btnLocChan
            // 
            this.btnLocChan.Location = new System.Drawing.Point(352, 86);
            this.btnLocChan.Name = "btnLocChan";
            this.btnLocChan.Size = new System.Drawing.Size(155, 46);
            this.btnLocChan.TabIndex = 4;
            this.btnLocChan.Text = "Lọc số chẵn";
            this.btnLocChan.UseVisualStyleBackColor = true;
            this.btnLocChan.Click += new System.EventHandler(this.btnLocChan_Click);
            // 
            // lstChan
            // 
            this.lstChan.FormattingEnabled = true;
            this.lstChan.ItemHeight = 25;
            this.lstChan.Location = new System.Drawing.Point(513, 12);
            this.lstChan.Name = "lstChan";
            this.lstChan.Size = new System.Drawing.Size(169, 229);
            this.lstChan.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(13, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 11);
            this.panel1.TabIndex = 5;
            // 
            // lvSanPhamGoc
            // 
            this.lvSanPhamGoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSanPhamGoc.FullRowSelect = true;
            this.lvSanPhamGoc.GridLines = true;
            this.lvSanPhamGoc.HideSelection = false;
            this.lvSanPhamGoc.Location = new System.Drawing.Point(18, 270);
            this.lvSanPhamGoc.Name = "lvSanPhamGoc";
            this.lvSanPhamGoc.Size = new System.Drawing.Size(311, 222);
            this.lvSanPhamGoc.TabIndex = 6;
            this.lvSanPhamGoc.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamGoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá Min:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(443, 285);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 30);
            this.txtMin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá Max:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(646, 285);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 30);
            this.txtMax.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(765, 285);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lvSanPhamTim
            // 
            this.lvSanPhamTim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSanPhamTim.FullRowSelect = true;
            this.lvSanPhamTim.GridLines = true;
            this.lvSanPhamTim.HideSelection = false;
            this.lvSanPhamTim.Location = new System.Drawing.Point(434, 321);
            this.lvSanPhamTim.Name = "lvSanPhamTim";
            this.lvSanPhamTim.Size = new System.Drawing.Size(406, 171);
            this.lvSanPhamTim.TabIndex = 6;
            this.lvSanPhamTim.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamTim.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 499);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvSanPhamTim);
            this.Controls.Add(this.lvSanPhamGoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLocChan);
            this.Controls.Add(this.lstChan);
            this.Controls.Add(this.lstGoc);
            this.Controls.Add(this.btnTaoDS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTaoDS;
        private System.Windows.Forms.ListBox lstGoc;
        private System.Windows.Forms.Button btnLocChan;
        private System.Windows.Forms.ListBox lstChan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvSanPhamGoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView lvSanPhamTim;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

