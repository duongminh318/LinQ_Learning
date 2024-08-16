namespace HocSkip
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lstSkip = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(107, 17);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(107, 64);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(100, 48);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstGoc
            // 
            this.lstGoc.FormattingEnabled = true;
            this.lstGoc.ItemHeight = 25;
            this.lstGoc.Location = new System.Drawing.Point(42, 121);
            this.lstGoc.Name = "lstGoc";
            this.lstGoc.Size = new System.Drawing.Size(165, 254);
            this.lstGoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Skip:";
            // 
            // txtSkip
            // 
            this.txtSkip.Location = new System.Drawing.Point(356, 76);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(100, 30);
            this.txtSkip.TabIndex = 5;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(463, 76);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(106, 30);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lstSkip
            // 
            this.lstSkip.FormattingEnabled = true;
            this.lstSkip.ItemHeight = 25;
            this.lstSkip.Location = new System.Drawing.Point(404, 121);
            this.lstSkip.Name = "lstSkip";
            this.lstSkip.Size = new System.Drawing.Size(165, 254);
            this.lstSkip.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 391);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.txtSkip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSkip);
            this.Controls.Add(this.lstGoc);
            this.Controls.Add(this.btnTaoDS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTaoDS;
        private System.Windows.Forms.ListBox lstGoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ListBox lstSkip;
    }
}

