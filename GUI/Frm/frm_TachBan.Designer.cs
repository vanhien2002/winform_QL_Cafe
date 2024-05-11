namespace GUI.Frm
{
    partial class frm_TachBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_CTHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_BanMuonTach = new System.Windows.Forms.DataGridView();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.btnBoChonSP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BanMuonTach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 575);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bàn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_CTHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(525, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(415, 575);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bàn đã chọn";
            // 
            // dtgv_CTHoaDon
            // 
            this.dtgv_CTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CTHoaDon.Location = new System.Drawing.Point(8, 23);
            this.dtgv_CTHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_CTHoaDon.Name = "dtgv_CTHoaDon";
            this.dtgv_CTHoaDon.RowHeadersWidth = 51;
            this.dtgv_CTHoaDon.Size = new System.Drawing.Size(399, 544);
            this.dtgv_CTHoaDon.TabIndex = 0;
            this.dtgv_CTHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CTHoaDon_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_BanMuonTach);
            this.groupBox3.Location = new System.Drawing.Point(1056, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(369, 575);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bàn Hiện Tại";
            // 
            // dtgv_BanMuonTach
            // 
            this.dtgv_BanMuonTach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BanMuonTach.Location = new System.Drawing.Point(8, 23);
            this.dtgv_BanMuonTach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_BanMuonTach.Name = "dtgv_BanMuonTach";
            this.dtgv_BanMuonTach.RowHeadersWidth = 51;
            this.dtgv_BanMuonTach.Size = new System.Drawing.Size(353, 544);
            this.dtgv_BanMuonTach.TabIndex = 0;
            // 
            // btnChonSP
            // 
            this.btnChonSP.Location = new System.Drawing.Point(948, 81);
            this.btnChonSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(100, 38);
            this.btnChonSP.TabIndex = 6;
            this.btnChonSP.Text = ">>";
            this.btnChonSP.UseVisualStyleBackColor = true;
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // btnBoChonSP
            // 
            this.btnBoChonSP.Location = new System.Drawing.Point(948, 142);
            this.btnBoChonSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoChonSP.Name = "btnBoChonSP";
            this.btnBoChonSP.Size = new System.Drawing.Size(100, 38);
            this.btnBoChonSP.TabIndex = 7;
            this.btnBoChonSP.Text = "<<";
            this.btnBoChonSP.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(948, 198);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 29);
            this.txtSoLuong.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(948, 271);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên bàn";
            // 
            // txtTenBan
            // 
            this.txtTenBan.AutoSize = true;
            this.txtTenBan.Location = new System.Drawing.Point(621, 20);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(30, 17);
            this.txtTenBan.TabIndex = 11;
            this.txtTenBan.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hóa đơn ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.AutoSize = true;
            this.txtMaHD.Location = new System.Drawing.Point(837, 20);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(61, 17);
            this.txtMaHD.TabIndex = 13;
            this.txtMaHD.Text = "txtMaHD";
            // 
            // frm_TachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 684);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnBoChonSP);
            this.Controls.Add(this.btnChonSP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TachBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TachBan";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BanMuonTach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.Button btnBoChonSP;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dtgv_CTHoaDon;
        private System.Windows.Forms.DataGridView dtgv_BanMuonTach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMaHD;
    }
}