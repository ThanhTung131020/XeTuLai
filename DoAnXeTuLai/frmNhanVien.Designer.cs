namespace DoAnXeTuLai
{
    partial class frmNhanVien
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
            this.label7 = new System.Windows.Forms.Label();
            this.btntimk = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnsapxep = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.cbbmachinhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.btnchonanh = new System.Windows.Forms.Button();
            this.picanh = new System.Windows.Forms.PictureBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(365, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "quản lý nhân viên";
            // 
            // btntimk
            // 
            this.btntimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimk.Image = global::DoAnXeTuLai.Properties.Resources.search__1_;
            this.btntimk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimk.Location = new System.Drawing.Point(402, 410);
            this.btntimk.Name = "btntimk";
            this.btntimk.Size = new System.Drawing.Size(101, 32);
            this.btntimk.TabIndex = 46;
            this.btntimk.Text = "&tìm kiếm";
            this.btntimk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimk.UseVisualStyleBackColor = true;
            this.btntimk.Click += new System.EventHandler(this.btntimk_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Image = global::DoAnXeTuLai.Properties.Resources.logout;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(644, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 57);
            this.button5.TabIndex = 45;
            this.button5.Text = "&thoát";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsapxep
            // 
            this.btnsapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsapxep.Image = global::DoAnXeTuLai.Properties.Resources.sort;
            this.btnsapxep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsapxep.Location = new System.Drawing.Point(470, 463);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(133, 57);
            this.btnsapxep.TabIndex = 44;
            this.btnsapxep.Text = "&sắp xếp";
            this.btnsapxep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsapxep.UseVisualStyleBackColor = true;
            this.btnsapxep.Click += new System.EventHandler(this.btnsapxep_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::DoAnXeTuLai.Properties.Resources.dustbin;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(332, 463);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 57);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "&xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Image = global::DoAnXeTuLai.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(187, 463);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(106, 57);
            this.btnsua.TabIndex = 42;
            this.btnsua.Text = "&sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::DoAnXeTuLai.Properties.Resources.add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(50, 463);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(111, 57);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "&thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(167, 412);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 30);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "nhập mã nhân viên";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 537);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(922, 181);
            this.dgvNhanVien.TabIndex = 39;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // cbbmachinhanh
            // 
            this.cbbmachinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbmachinhanh.FormattingEnabled = true;
            this.cbbmachinhanh.Location = new System.Drawing.Point(585, 360);
            this.cbbmachinhanh.Name = "cbbmachinhanh";
            this.cbbmachinhanh.Size = new System.Drawing.Size(208, 33);
            this.cbbmachinhanh.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(467, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "mã chi nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(467, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "CCCD";
            // 
            // txtcccd
            // 
            this.txtcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcccd.Location = new System.Drawing.Point(585, 304);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(208, 30);
            this.txtcccd.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(467, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "ngày sinh";
            // 
            // dtpns
            // 
            this.dtpns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpns.Location = new System.Drawing.Point(585, 258);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(208, 30);
            this.dtpns.TabIndex = 33;
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.Items.AddRange(new object[] {
            "Nhân viên kinh doanh",
            "Kế toán",
            "Giám đốc",
            "quản lý"});
            this.cbbchucvu.Location = new System.Drawing.Point(167, 358);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(208, 33);
            this.cbbchucvu.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(47, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(47, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "tên nhân viên";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttennhanvien.Location = new System.Drawing.Point(167, 304);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(208, 30);
            this.txttennhanvien.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(47, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "mã nhân viên";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmanhanvien.Location = new System.Drawing.Point(167, 253);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(208, 30);
            this.txtmanhanvien.TabIndex = 27;
            // 
            // btnchonanh
            // 
            this.btnchonanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchonanh.Location = new System.Drawing.Point(409, 197);
            this.btnchonanh.Name = "btnchonanh";
            this.btnchonanh.Size = new System.Drawing.Size(113, 35);
            this.btnchonanh.TabIndex = 26;
            this.btnchonanh.Text = "chọn ảnh";
            this.btnchonanh.UseVisualStyleBackColor = true;
            this.btnchonanh.Click += new System.EventHandler(this.btnchonanh_Click);
            // 
            // picanh
            // 
            this.picanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picanh.Location = new System.Drawing.Point(389, 59);
            this.picanh.Name = "picanh";
            this.picanh.Size = new System.Drawing.Size(156, 132);
            this.picanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picanh.TabIndex = 25;
            this.picanh.TabStop = false;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlammoi.Image = global::DoAnXeTuLai.Properties.Resources.reset;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(783, 463);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(108, 47);
            this.btnlammoi.TabIndex = 81;
            this.btnlammoi.Text = "&làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnXeTuLai.Properties.Resources.xee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 718);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btntimk);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnsapxep);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.cbbmachinhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpns);
            this.Controls.Add(this.cbbchucvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.btnchonanh);
            this.Controls.Add(this.picanh);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntimk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnsapxep;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.ComboBox cbbmachinhanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button btnchonanh;
        private System.Windows.Forms.PictureBox picanh;
        private System.Windows.Forms.Button btnlammoi;
    }
}