namespace BTVNBuoi4
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
            this.lblMSNV = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(24, 21);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(38, 13);
            this.lblMSNV.TabIndex = 0;
            this.lblMSNV.Text = "MSNV";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(24, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(44, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên NV";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(24, 105);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 2;
            this.lblLuong.Text = "Lương";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(68, 21);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(132, 20);
            this.txtMSNV.TabIndex = 3;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(68, 98);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(132, 20);
            this.txtLuong.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(68, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(132, 20);
            this.txtTen.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(74, 149);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(167, 149);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 198);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMSNV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}