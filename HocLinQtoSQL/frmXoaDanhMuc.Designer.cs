namespace HocLinQtoSQL
{
    partial class frmXoaDanhMuc
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
            this.lstDanhMuc = new System.Windows.Forms.ListBox();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhMuc
            // 
            this.lstDanhMuc.FormattingEnabled = true;
            this.lstDanhMuc.ItemHeight = 25;
            this.lstDanhMuc.Location = new System.Drawing.Point(22, 13);
            this.lstDanhMuc.Name = "lstDanhMuc";
            this.lstDanhMuc.Size = new System.Drawing.Size(403, 329);
            this.lstDanhMuc.TabIndex = 0;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(22, 349);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(197, 51);
            this.btnXoaDM.TabIndex = 1;
            this.btnXoaDM.Text = "Xóa Danh Mục";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // frmXoaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 412);
            this.Controls.Add(this.btnXoaDM);
            this.Controls.Add(this.lstDanhMuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmXoaDanhMuc";
            this.Text = "frmXoaDanhMuc";
            this.Load += new System.EventHandler(this.frmXoaDanhMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhMuc;
        private System.Windows.Forms.Button btnXoaDM;
    }
}