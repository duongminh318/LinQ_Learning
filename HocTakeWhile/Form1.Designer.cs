﻿namespace HocTakeWhile
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstTakeWhile = new System.Windows.Forms.ListBox();
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
            this.txtN.Location = new System.Drawing.Point(84, 17);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(84, 54);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(100, 35);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstN
            // 
            this.lstN.FormattingEnabled = true;
            this.lstN.ItemHeight = 25;
            this.lstN.Location = new System.Drawing.Point(18, 101);
            this.lstN.Name = "lstN";
            this.lstN.Size = new System.Drawing.Size(173, 254);
            this.lstN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TakeWhile(lọc số lẻ)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "TakeWhile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstTakeWhile
            // 
            this.lstTakeWhile.FormattingEnabled = true;
            this.lstTakeWhile.ItemHeight = 25;
            this.lstTakeWhile.Location = new System.Drawing.Point(239, 101);
            this.lstTakeWhile.Name = "lstTakeWhile";
            this.lstTakeWhile.Size = new System.Drawing.Size(154, 254);
            this.lstTakeWhile.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 386);
            this.Controls.Add(this.lstTakeWhile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstN);
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
        private System.Windows.Forms.ListBox lstN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstTakeWhile;
    }
}
