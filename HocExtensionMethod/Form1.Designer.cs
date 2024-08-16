namespace HocExtensionMethod
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
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.btnNoi = new System.Windows.Forms.Button();
            this.lblKetQuaNoiChuoi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(22, 49);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(118, 53);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(31, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(31, 120);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(64, 25);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chuỗi  1:";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Location = new System.Drawing.Point(318, 17);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(158, 30);
            this.txtChuoi1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chuỗi  2:";
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Location = new System.Drawing.Point(318, 60);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(158, 30);
            this.txtChuoi2.TabIndex = 4;
            // 
            // btnNoi
            // 
            this.btnNoi.Location = new System.Drawing.Point(318, 106);
            this.btnNoi.Name = "btnNoi";
            this.btnNoi.Size = new System.Drawing.Size(167, 39);
            this.btnNoi.TabIndex = 5;
            this.btnNoi.Text = "Nối chuỗi";
            this.btnNoi.UseVisualStyleBackColor = true;
            this.btnNoi.Click += new System.EventHandler(this.btnNoi_Click);
            // 
            // lblKetQuaNoiChuoi
            // 
            this.lblKetQuaNoiChuoi.AutoSize = true;
            this.lblKetQuaNoiChuoi.Location = new System.Drawing.Point(232, 144);
            this.lblKetQuaNoiChuoi.Name = "lblKetQuaNoiChuoi";
            this.lblKetQuaNoiChuoi.Size = new System.Drawing.Size(64, 25);
            this.lblKetQuaNoiChuoi.TabIndex = 6;
            this.lblKetQuaNoiChuoi.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test Sinh Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKetQuaNoiChuoi);
            this.Controls.Add(this.btnNoi);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnTinhTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.Button btnNoi;
        private System.Windows.Forms.Label lblKetQuaNoiChuoi;
        private System.Windows.Forms.Button button1;
    }
}

