namespace HocAll
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
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstGiaTri = new System.Windows.Forms.ListBox();
            this.btnToanSoChan = new System.Windows.Forms.Button();
            this.btToanSoLe = new System.Windows.Forms.Button();
            this.btnToanSoDuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Giá trị:";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(154, 17);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(100, 36);
            this.txtGiaTri.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(274, 13);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(112, 34);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstGiaTri
            // 
            this.lstGiaTri.FormattingEnabled = true;
            this.lstGiaTri.ItemHeight = 29;
            this.lstGiaTri.Location = new System.Drawing.Point(44, 69);
            this.lstGiaTri.Name = "lstGiaTri";
            this.lstGiaTri.Size = new System.Drawing.Size(210, 178);
            this.lstGiaTri.TabIndex = 3;
            // 
            // btnToanSoChan
            // 
            this.btnToanSoChan.Location = new System.Drawing.Point(274, 69);
            this.btnToanSoChan.Name = "btnToanSoChan";
            this.btnToanSoChan.Size = new System.Drawing.Size(160, 41);
            this.btnToanSoChan.TabIndex = 4;
            this.btnToanSoChan.Text = "toàn chỗ chẵn?";
            this.btnToanSoChan.UseVisualStyleBackColor = true;
            this.btnToanSoChan.Click += new System.EventHandler(this.btnToanSoChan_Click);
            // 
            // btToanSoLe
            // 
            this.btToanSoLe.Location = new System.Drawing.Point(274, 126);
            this.btToanSoLe.Name = "btToanSoLe";
            this.btToanSoLe.Size = new System.Drawing.Size(160, 41);
            this.btToanSoLe.TabIndex = 4;
            this.btToanSoLe.Text = "Toàn số lẻ?";
            this.btToanSoLe.UseVisualStyleBackColor = true;
            this.btToanSoLe.Click += new System.EventHandler(this.btToanSoLe_Click);
            // 
            // btnToanSoDuong
            // 
            this.btnToanSoDuong.Location = new System.Drawing.Point(274, 194);
            this.btnToanSoDuong.Name = "btnToanSoDuong";
            this.btnToanSoDuong.Size = new System.Drawing.Size(160, 41);
            this.btnToanSoDuong.TabIndex = 4;
            this.btnToanSoDuong.Text = "toàn số dương?";
            this.btnToanSoDuong.UseVisualStyleBackColor = true;
            this.btnToanSoDuong.Click += new System.EventHandler(this.btnToanSoDuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 372);
            this.Controls.Add(this.btnToanSoDuong);
            this.Controls.Add(this.btToanSoLe);
            this.Controls.Add(this.btnToanSoChan);
            this.Controls.Add(this.lstGiaTri);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstGiaTri;
        private System.Windows.Forms.Button btnToanSoChan;
        private System.Windows.Forms.Button btToanSoLe;
        private System.Windows.Forms.Button btnToanSoDuong;
    }
}

