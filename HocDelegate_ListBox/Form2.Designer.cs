namespace HocDelegate_ListBox
{
    partial class Form2
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
            this.btnToNguyenTo = new System.Windows.Forms.Button();
            this.btnToSole = new System.Windows.Forms.Button();
            this.btnToSoChan = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnToNguyenTo
            // 
            this.btnToNguyenTo.Location = new System.Drawing.Point(245, 183);
            this.btnToNguyenTo.Name = "btnToNguyenTo";
            this.btnToNguyenTo.Size = new System.Drawing.Size(137, 60);
            this.btnToNguyenTo.TabIndex = 3;
            this.btnToNguyenTo.Text = "Tô Nguyên tố";
            this.btnToNguyenTo.UseVisualStyleBackColor = true;
            this.btnToNguyenTo.Click += new System.EventHandler(this.btnToNguyenTo_Click);
            // 
            // btnToSole
            // 
            this.btnToSole.Location = new System.Drawing.Point(245, 90);
            this.btnToSole.Name = "btnToSole";
            this.btnToSole.Size = new System.Drawing.Size(137, 60);
            this.btnToSole.TabIndex = 4;
            this.btnToSole.Text = "Tô số lẻ";
            this.btnToSole.UseVisualStyleBackColor = true;
            this.btnToSole.Click += new System.EventHandler(this.btnToSole_Click);
            // 
            // btnToSoChan
            // 
            this.btnToSoChan.Location = new System.Drawing.Point(245, 13);
            this.btnToSoChan.Name = "btnToSoChan";
            this.btnToSoChan.Size = new System.Drawing.Size(137, 60);
            this.btnToSoChan.TabIndex = 5;
            this.btnToSoChan.Text = "Tô số chẵn";
            this.btnToSoChan.UseVisualStyleBackColor = true;
            this.btnToSoChan.Click += new System.EventHandler(this.btnToSoChan_Click);
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
            this.lstSo.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 346);
            this.Controls.Add(this.btnToNguyenTo);
            this.Controls.Add(this.btnToSole);
            this.Controls.Add(this.btnToSoChan);
            this.Controls.Add(this.lstSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToNguyenTo;
        private System.Windows.Forms.Button btnToSole;
        private System.Windows.Forms.Button btnToSoChan;
        private System.Windows.Forms.ListBox lstSo;
    }
}