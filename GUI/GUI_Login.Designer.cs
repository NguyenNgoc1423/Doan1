namespace GUI
{
    partial class GUI_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lableTenDangNhap = new System.Windows.Forms.Label();
            this.labelMatkhau = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(487, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "XIN CHÀO";
            // 
            // lableTenDangNhap
            // 
            this.lableTenDangNhap.AutoSize = true;
            this.lableTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lableTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lableTenDangNhap.Location = new System.Drawing.Point(364, 190);
            this.lableTenDangNhap.Name = "lableTenDangNhap";
            this.lableTenDangNhap.Size = new System.Drawing.Size(156, 24);
            this.lableTenDangNhap.TabIndex = 10;
            this.lableTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // labelMatkhau
            // 
            this.labelMatkhau.AutoSize = true;
            this.labelMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.labelMatkhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatkhau.Location = new System.Drawing.Point(420, 296);
            this.labelMatkhau.Name = "labelMatkhau";
            this.labelMatkhau.Size = new System.Drawing.Size(100, 24);
            this.labelMatkhau.TabIndex = 11;
            this.labelMatkhau.Text = "Mật Khẩu";
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(556, 193);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(192, 22);
            this.txtdn.TabIndex = 12;
            this.txtdn.TextChanged += new System.EventHandler(this.txtdn_TextChanged);
            this.txtdn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdn_KeyUp);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(556, 299);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(192, 22);
            this.txtmk.TabIndex = 13;
            this.txtmk.UseSystemPasswordChar = true;
            this.txtmk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmk_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(424, 391);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 37);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(638, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 37);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.labelMatkhau);
            this.Controls.Add(this.lableTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.GUI_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableTenDangNhap;
        private System.Windows.Forms.Label labelMatkhau;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnThoat;
    }
}

