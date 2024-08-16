namespace HocOfType
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
            this.lvNhanVienGoc = new System.Windows.Forms.ListView();
            this.btnChinhThuc = new System.Windows.Forms.Button();
            this.btnThoiVu = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNhanVienLoc = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.chkLaThoiVu = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvNhanVienGoc
            // 
            this.lvNhanVienGoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNhanVienGoc.FullRowSelect = true;
            this.lvNhanVienGoc.GridLines = true;
            this.lvNhanVienGoc.HideSelection = false;
            this.lvNhanVienGoc.Location = new System.Drawing.Point(15, 3);
            this.lvNhanVienGoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvNhanVienGoc.Name = "lvNhanVienGoc";
            this.lvNhanVienGoc.Size = new System.Drawing.Size(366, 207);
            this.lvNhanVienGoc.TabIndex = 0;
            this.lvNhanVienGoc.UseCompatibleStateImageBehavior = false;
            this.lvNhanVienGoc.View = System.Windows.Forms.View.Details;
            // 
            // btnChinhThuc
            // 
            this.btnChinhThuc.Location = new System.Drawing.Point(15, 219);
            this.btnChinhThuc.Name = "btnChinhThuc";
            this.btnChinhThuc.Size = new System.Drawing.Size(179, 54);
            this.btnChinhThuc.TabIndex = 1;
            this.btnChinhThuc.Text = "Lọc chính thức";
            this.btnChinhThuc.UseVisualStyleBackColor = true;
            this.btnChinhThuc.Click += new System.EventHandler(this.btnChinhThuc_Click);
            // 
            // btnThoiVu
            // 
            this.btnThoiVu.Location = new System.Drawing.Point(226, 218);
            this.btnThoiVu.Name = "btnThoiVu";
            this.btnThoiVu.Size = new System.Drawing.Size(145, 54);
            this.btnThoiVu.TabIndex = 1;
            this.btnThoiVu.Text = "Lọc thời vụ";
            this.btnThoiVu.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 238;
            // 
            // lvNhanVienLoc
            // 
            this.lvNhanVienLoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvNhanVienLoc.FullRowSelect = true;
            this.lvNhanVienLoc.GridLines = true;
            this.lvNhanVienLoc.HideSelection = false;
            this.lvNhanVienLoc.Location = new System.Drawing.Point(15, 282);
            this.lvNhanVienLoc.Margin = new System.Windows.Forms.Padding(6);
            this.lvNhanVienLoc.Name = "lvNhanVienLoc";
            this.lvNhanVienLoc.Size = new System.Drawing.Size(690, 207);
            this.lvNhanVienLoc.TabIndex = 0;
            this.lvNhanVienLoc.UseCompatibleStateImageBehavior = false;
            this.lvNhanVienLoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên";
            this.columnHeader4.Width = 238;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(487, 8);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(187, 30);
            this.txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(487, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 30);
            this.txtTen.TabIndex = 4;
            // 
            // chkLaThoiVu
            // 
            this.chkLaThoiVu.AutoSize = true;
            this.chkLaThoiVu.Location = new System.Drawing.Point(487, 123);
            this.chkLaThoiVu.Name = "chkLaThoiVu";
            this.chkLaThoiVu.Size = new System.Drawing.Size(115, 29);
            this.chkLaThoiVu.TabIndex = 5;
            this.chkLaThoiVu.Text = "Là thời vụ";
            this.chkLaThoiVu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(487, 173);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 37);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 497);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.chkLaThoiVu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoiVu);
            this.Controls.Add(this.btnChinhThuc);
            this.Controls.Add(this.lvNhanVienLoc);
            this.Controls.Add(this.lvNhanVienGoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNhanVienGoc;
        private System.Windows.Forms.Button btnChinhThuc;
        private System.Windows.Forms.Button btnThoiVu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvNhanVienLoc;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox chkLaThoiVu;
        private System.Windows.Forms.Button btnLuu;
    }
}

