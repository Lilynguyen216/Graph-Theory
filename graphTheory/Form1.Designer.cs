namespace graphTheory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoThi = new FontAwesome.Sharp.IconButton();
            this.btnMaTran = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(252, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 208);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(230, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM TPHCM\r\nKHOA CÔNG NGHỆ THÔNG TIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::graphTheory.Properties.Resources.CNTT;
            // this.pictureBox1.Image = global::graphTheory.
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoThi
            // 
            this.btnDoThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoThi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoThi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDoThi.IconColor = System.Drawing.Color.Black;
            this.btnDoThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoThi.Location = new System.Drawing.Point(12, 158);
            this.btnDoThi.Name = "btnDoThi";
            this.btnDoThi.Size = new System.Drawing.Size(222, 58);
            this.btnDoThi.TabIndex = 2;
            this.btnDoThi.Text = "Đồ thị";
            this.btnDoThi.UseVisualStyleBackColor = true;
            this.btnDoThi.Click += new System.EventHandler(this.btnDoThi_Click);
            // 
            // btnMaTran
            // 
            this.btnMaTran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaTran.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMaTran.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaTran.IconColor = System.Drawing.Color.Black;
            this.btnMaTran.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaTran.Location = new System.Drawing.Point(12, 260);
            this.btnMaTran.Name = "btnMaTran";
            this.btnMaTran.Size = new System.Drawing.Size(222, 58);
            this.btnMaTran.TabIndex = 2;
            this.btnMaTran.Text = "Ma trận";
            this.btnMaTran.UseVisualStyleBackColor = true;
            this.btnMaTran.Click += new System.EventHandler(this.btnMaTran_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(837, 388);
            this.Controls.Add(this.btnMaTran);
            this.Controls.Add(this.btnDoThi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu chọn chức năng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnDoThi;
        private FontAwesome.Sharp.IconButton btnMaTran;
    }
}

