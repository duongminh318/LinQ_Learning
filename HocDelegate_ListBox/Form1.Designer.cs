namespace HocDelegate_ListBox
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
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnToSoChan = new System.Windows.Forms.Button();
            this.btnToSole = new System.Windows.Forms.Button();
            this.btnToNguyenTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 25;
            this.lstSo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.lstSo.Location = new System.Drawing.Point(13, 13);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(217, 329);
            this.lstSo.TabIndex = 0;
            // 
            // btnToSoChan
            // 
            this.btnToSoChan.Location = new System.Drawing.Point(256, 29);
            this.btnToSoChan.Name = "btnToSoChan";
            this.btnToSoChan.Size = new System.Drawing.Size(137, 60);
            this.btnToSoChan.TabIndex = 1;
            this.btnToSoChan.Text = "Tô số chẵn";
            this.btnToSoChan.UseVisualStyleBackColor = true;
            this.btnToSoChan.Click += new System.EventHandler(this.btnToSoChan_Click);
            // 
            // btnToSole
            // 
            this.btnToSole.Location = new System.Drawing.Point(256, 106);
            this.btnToSole.Name = "btnToSole";
            this.btnToSole.Size = new System.Drawing.Size(137, 60);
            this.btnToSole.TabIndex = 1;
            this.btnToSole.Text = "Tô số lẻ";
            this.btnToSole.UseVisualStyleBackColor = true;
            this.btnToSole.Click += new System.EventHandler(this.btnToSole_Click);
            // 
            // btnToNguyenTo
            // 
            this.btnToNguyenTo.Location = new System.Drawing.Point(256, 199);
            this.btnToNguyenTo.Name = "btnToNguyenTo";
            this.btnToNguyenTo.Size = new System.Drawing.Size(137, 60);
            this.btnToNguyenTo.TabIndex = 1;
            this.btnToNguyenTo.Text = "Tô Nguyên tố";
            this.btnToNguyenTo.UseVisualStyleBackColor = true;
            this.btnToNguyenTo.Click += new System.EventHandler(this.btnToNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 363);
            this.Controls.Add(this.btnToNguyenTo);
            this.Controls.Add(this.btnToSole);
            this.Controls.Add(this.btnToSoChan);
            this.Controls.Add(this.lstSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnToSoChan;
        private System.Windows.Forms.Button btnToSole;
        private System.Windows.Forms.Button btnToNguyenTo;
    }
}

