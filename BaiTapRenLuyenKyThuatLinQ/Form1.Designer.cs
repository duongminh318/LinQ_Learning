namespace BaiTapRenLuyenKyThuatLinQ
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
            this.btnXemSNT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lstSNT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnXemSNT
            // 
            this.btnXemSNT.Location = new System.Drawing.Point(241, 10);
            this.btnXemSNT.Name = "btnXemSNT";
            this.btnXemSNT.Size = new System.Drawing.Size(222, 44);
            this.btnXemSNT.TabIndex = 0;
            this.btnXemSNT.Text = "Xem số nguyên tố";
            this.btnXemSNT.UseVisualStyleBackColor = true;
            this.btnXemSNT.Click += new System.EventHandler(this.btnXemSNT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(115, 17);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 2;
            // 
            // lstSNT
            // 
            this.lstSNT.FormattingEnabled = true;
            this.lstSNT.ItemHeight = 25;
            this.lstSNT.Location = new System.Drawing.Point(115, 54);
            this.lstSNT.Name = "lstSNT";
            this.lstSNT.Size = new System.Drawing.Size(337, 229);
            this.lstSNT.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 369);
            this.Controls.Add(this.lstSNT);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemSNT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemSNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ListBox lstSNT;
    }
}

