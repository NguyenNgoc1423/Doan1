namespace GUI
{
    partial class GUI_TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimKiem));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbcachtim = new System.Windows.Forms.ComboBox();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cách Tìm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(210, 121);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 37);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "&Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Từ Khoá";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(431, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Quay Về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbcachtim
            // 
            this.cbbcachtim.FormattingEnabled = true;
            this.cbbcachtim.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên",
            "Mã Hàng",
            "Tên Hàng",
            "Mã Khách Hàng",
            "Tên Khách Hàng ",
            "Mã Chất Liệu",
            "Tên Chất Liệu",
            "Mã Hoá Đơn Bán",
            "Chi Tiết Hoá Đơn Bán"});
            this.cbbcachtim.Location = new System.Drawing.Point(143, 56);
            this.cbbcachtim.Name = "cbbcachtim";
            this.cbbcachtim.Size = new System.Drawing.Size(176, 24);
            this.cbbcachtim.TabIndex = 15;
            this.cbbcachtim.SelectedIndexChanged += new System.EventHandler(this.cbbcachtim_SelectedIndexChanged);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(508, 58);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(236, 22);
            this.txtTukhoa.TabIndex = 16;
            this.txtTukhoa.TextChanged += new System.EventHandler(this.txtTukhoa_TextChanged);
            // 
            // dgvTK
            // 
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(6, 173);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.Size = new System.Drawing.Size(782, 265);
            this.dgvTK.TabIndex = 17;
            this.dgvTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellContentClick);
            // 
            // GUI_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.cbbcachtim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "GUI_TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_TimKiem";
            this.Load += new System.EventHandler(this.GUI_TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbcachtim;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.DataGridView dgvTK;
    }
}