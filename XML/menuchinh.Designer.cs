namespace XML
{
    partial class menuchinh
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
            this.btnsinhvien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsinhvien
            // 
            this.btnsinhvien.Location = new System.Drawing.Point(74, 122);
            this.btnsinhvien.Name = "btnsinhvien";
            this.btnsinhvien.Size = new System.Drawing.Size(151, 66);
            this.btnsinhvien.TabIndex = 0;
            this.btnsinhvien.Text = "SinhVien";
            this.btnsinhvien.UseVisualStyleBackColor = true;
            this.btnsinhvien.Click += new System.EventHandler(this.btnsinhvien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "QuanLy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(674, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsinhvien);
            this.Name = "menuchinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menuchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsinhvien;
        private System.Windows.Forms.Button button2;
    }
}

