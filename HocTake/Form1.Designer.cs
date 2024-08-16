namespace HocTake
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
            this.lstN = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTake = new System.Windows.Forms.TextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.lstTake = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvDanhBa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVeDau = new System.Windows.Forms.Button();
            this.btnVeTruoc = new System.Windows.Forms.Button();
            this.btnVeSau = new System.Windows.Forms.Button();
            this.btnVeCuoi = new System.Windows.Forms.Button();
            this.lblViTri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(34, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(34, 64);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(108, 52);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstN
            // 
            this.lstN.FormattingEnabled = true;
            this.lstN.ItemHeight = 25;
            this.lstN.Location = new System.Drawing.Point(18, 139);
            this.lstN.Name = "lstN";
            this.lstN.Size = new System.Drawing.Size(129, 279);
            this.lstN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Take:";
            // 
            // txtTake
            // 
            this.txtTake.Location = new System.Drawing.Point(210, 40);
            this.txtTake.Name = "txtTake";
            this.txtTake.Size = new System.Drawing.Size(100, 30);
            this.txtTake.TabIndex = 5;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(210, 77);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(100, 34);
            this.btnTake.TabIndex = 6;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lstTake
            // 
            this.lstTake.FormattingEnabled = true;
            this.lstTake.ItemHeight = 25;
            this.lstTake.Location = new System.Drawing.Point(167, 139);
            this.lstTake.Name = "lstTake";
            this.lstTake.Size = new System.Drawing.Size(126, 279);
            this.lstTake.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(333, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 405);
            this.panel1.TabIndex = 7;
            // 
            // lvDanhBa
            // 
            this.lvDanhBa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDanhBa.FullRowSelect = true;
            this.lvDanhBa.GridLines = true;
            this.lvDanhBa.HideSelection = false;
            this.lvDanhBa.Location = new System.Drawing.Point(374, 19);
            this.lvDanhBa.Name = "lvDanhBa";
            this.lvDanhBa.Size = new System.Drawing.Size(489, 298);
            this.lvDanhBa.TabIndex = 8;
            this.lvDanhBa.UseCompatibleStateImageBehavior = false;
            this.lvDanhBa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số phone";
            this.columnHeader2.Width = 200;
            // 
            // btnVeDau
            // 
            this.btnVeDau.Location = new System.Drawing.Point(374, 324);
            this.btnVeDau.Name = "btnVeDau";
            this.btnVeDau.Size = new System.Drawing.Size(71, 40);
            this.btnVeDau.TabIndex = 9;
            this.btnVeDau.Text = "|<";
            this.btnVeDau.UseVisualStyleBackColor = true;
            // 
            // btnVeTruoc
            // 
            this.btnVeTruoc.Location = new System.Drawing.Point(475, 324);
            this.btnVeTruoc.Name = "btnVeTruoc";
            this.btnVeTruoc.Size = new System.Drawing.Size(61, 40);
            this.btnVeTruoc.TabIndex = 9;
            this.btnVeTruoc.Text = "<<";
            this.btnVeTruoc.UseVisualStyleBackColor = true;
            this.btnVeTruoc.Click += new System.EventHandler(this.btnVeTruoc_Click);
            // 
            // btnVeSau
            // 
            this.btnVeSau.Location = new System.Drawing.Point(712, 323);
            this.btnVeSau.Name = "btnVeSau";
            this.btnVeSau.Size = new System.Drawing.Size(55, 40);
            this.btnVeSau.TabIndex = 9;
            this.btnVeSau.Text = ">>";
            this.btnVeSau.UseVisualStyleBackColor = true;
            this.btnVeSau.Click += new System.EventHandler(this.btnVeSau_Click);
            // 
            // btnVeCuoi
            // 
            this.btnVeCuoi.Location = new System.Drawing.Point(792, 323);
            this.btnVeCuoi.Name = "btnVeCuoi";
            this.btnVeCuoi.Size = new System.Drawing.Size(55, 40);
            this.btnVeCuoi.TabIndex = 9;
            this.btnVeCuoi.Text = ">|";
            this.btnVeCuoi.UseVisualStyleBackColor = true;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(576, 332);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(64, 25);
            this.lblViTri.TabIndex = 10;
            this.lblViTri.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 459);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.btnVeCuoi);
            this.Controls.Add(this.btnVeSau);
            this.Controls.Add(this.btnVeTruoc);
            this.Controls.Add(this.btnVeDau);
            this.Controls.Add(this.lvDanhBa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.txtTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTake);
            this.Controls.Add(this.lstN);
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
        private System.Windows.Forms.ListBox lstN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTake;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListBox lstTake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvDanhBa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnVeDau;
        private System.Windows.Forms.Button btnVeTruoc;
        private System.Windows.Forms.Button btnVeSau;
        private System.Windows.Forms.Button btnVeCuoi;
        private System.Windows.Forms.Label lblViTri;
    }
}

