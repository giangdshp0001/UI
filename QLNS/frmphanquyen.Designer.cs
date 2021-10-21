namespace QLNS
{
    partial class frmphanquyen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmphanquyen));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbNVCongDoan = new System.Windows.Forms.RadioButton();
            this.rbNVTaiChinh = new System.Windows.Forms.RadioButton();
            this.rbNVPhongNhanSu = new System.Windows.Forms.RadioButton();
            this.rbQuanTriVien = new System.Windows.Forms.RadioButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.GridPhanQuyen = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenDoiMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenQLCongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenQLTaiChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenQuanTriHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenQuanLiNhanSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new QLNS.DataSet1();
            this.tblTTNVCoBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTTNVCoBanTableAdapter = new QLNS.DataSet1TableAdapters.TblTTNVCoBanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTNVCoBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "các chức năng";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::QLNS.Properties.Resources.xanh;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::QLNS.Properties.Resources.upload;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.Location = new System.Drawing.Point(97, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "Mới   ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::QLNS.Properties.Resources._1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(519, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thoát ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::QLNS.Properties.Resources.remove_user;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(417, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa   ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QLNS.Properties.Resources.add_user;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(199, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QLNS.Properties.Resources.edit_user;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(308, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa   ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbUser);
            this.groupBox1.Controls.Add(this.rbNVCongDoan);
            this.groupBox1.Controls.Add(this.rbNVTaiChinh);
            this.groupBox1.Controls.Add(this.rbNVPhongNhanSu);
            this.groupBox1.Controls.Add(this.rbQuanTriVien);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(333, 67);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(48, 19);
            this.rbUser.TabIndex = 14;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbNVCongDoan
            // 
            this.rbNVCongDoan.AutoSize = true;
            this.rbNVCongDoan.Location = new System.Drawing.Point(333, 42);
            this.rbNVCongDoan.Name = "rbNVCongDoan";
            this.rbNVCongDoan.Size = new System.Drawing.Size(128, 19);
            this.rbNVCongDoan.TabIndex = 13;
            this.rbNVCongDoan.TabStop = true;
            this.rbNVCongDoan.Text = "Nhân viên Công đoàn";
            this.rbNVCongDoan.UseVisualStyleBackColor = true;
            this.rbNVCongDoan.CheckedChanged += new System.EventHandler(this.rbNVCongDoan_CheckedChanged);
            // 
            // rbNVTaiChinh
            // 
            this.rbNVTaiChinh.AutoSize = true;
            this.rbNVTaiChinh.Location = new System.Drawing.Point(178, 84);
            this.rbNVTaiChinh.Name = "rbNVTaiChinh";
            this.rbNVTaiChinh.Size = new System.Drawing.Size(118, 19);
            this.rbNVTaiChinh.TabIndex = 12;
            this.rbNVTaiChinh.TabStop = true;
            this.rbNVTaiChinh.Text = "Nhân viên tài chính";
            this.rbNVTaiChinh.UseVisualStyleBackColor = true;
            this.rbNVTaiChinh.CheckedChanged += new System.EventHandler(this.rbNVTaiChinh_CheckedChanged);
            // 
            // rbNVPhongNhanSu
            // 
            this.rbNVPhongNhanSu.AutoSize = true;
            this.rbNVPhongNhanSu.Location = new System.Drawing.Point(178, 59);
            this.rbNVPhongNhanSu.Name = "rbNVPhongNhanSu";
            this.rbNVPhongNhanSu.Size = new System.Drawing.Size(131, 19);
            this.rbNVPhongNhanSu.TabIndex = 11;
            this.rbNVPhongNhanSu.TabStop = true;
            this.rbNVPhongNhanSu.Text = "Nhân viên p. Nhân sự";
            this.rbNVPhongNhanSu.UseVisualStyleBackColor = true;
            this.rbNVPhongNhanSu.CheckedChanged += new System.EventHandler(this.rbNVPhongNhanSu_CheckedChanged);
            // 
            // rbQuanTriVien
            // 
            this.rbQuanTriVien.AutoSize = true;
            this.rbQuanTriVien.Location = new System.Drawing.Point(178, 34);
            this.rbQuanTriVien.Name = "rbQuanTriVien";
            this.rbQuanTriVien.Size = new System.Drawing.Size(88, 19);
            this.rbQuanTriVien.TabIndex = 10;
            this.rbQuanTriVien.TabStop = true;
            this.rbQuanTriVien.Text = "Quản trị viên";
            this.rbQuanTriVien.UseVisualStyleBackColor = true;
            this.rbQuanTriVien.CheckedChanged += new System.EventHandler(this.rbQuanTriVien_CheckedChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(18, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(127, 21);
            this.txtUser.TabIndex = 9;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(648, 26);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(84, 35);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(537, 26);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 35);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btOK_Click);
            // 
            // GridPhanQuyen
            // 
            this.GridPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Quyen,
            this.QuyenDoiMatKhau,
            this.QuyenQLCongDoan,
            this.QuyenQLTaiChinh,
            this.QuyenQuanTriHeThong,
            this.QuyenQuanLiNhanSu});
            this.GridPhanQuyen.Location = new System.Drawing.Point(29, 179);
            this.GridPhanQuyen.MultiSelect = false;
            this.GridPhanQuyen.Name = "GridPhanQuyen";
            this.GridPhanQuyen.ReadOnly = true;
            this.GridPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPhanQuyen.Size = new System.Drawing.Size(801, 284);
            this.GridPhanQuyen.TabIndex = 3;
            this.GridPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPhanQuyen_CellContentClick);
            this.GridPhanQuyen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPhanQuyen_CellDoubleClick);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 177.665F;
            this.Username.HeaderText = "Tên tài khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.FillWeight = 138.9873F;
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            // 
            // QuyenDoiMatKhau
            // 
            this.QuyenDoiMatKhau.DataPropertyName = "QuyenDoiMatKhau";
            this.QuyenDoiMatKhau.FillWeight = 110.1263F;
            this.QuyenDoiMatKhau.HeaderText = "Đổi Mật Khẩu";
            this.QuyenDoiMatKhau.Name = "QuyenDoiMatKhau";
            this.QuyenDoiMatKhau.ReadOnly = true;
            // 
            // QuyenQLCongDoan
            // 
            this.QuyenQLCongDoan.DataPropertyName = "QuyenQLCongDoan";
            this.QuyenQLCongDoan.FillWeight = 88.59039F;
            this.QuyenQLCongDoan.HeaderText = "Quản lý công đoàn";
            this.QuyenQLCongDoan.Name = "QuyenQLCongDoan";
            this.QuyenQLCongDoan.ReadOnly = true;
            // 
            // QuyenQLTaiChinh
            // 
            this.QuyenQLTaiChinh.DataPropertyName = "QuyenQLTaiChinh";
            this.QuyenQLTaiChinh.FillWeight = 72.52047F;
            this.QuyenQLTaiChinh.HeaderText = "Quản lý tài chính";
            this.QuyenQLTaiChinh.Name = "QuyenQLTaiChinh";
            this.QuyenQLTaiChinh.ReadOnly = true;
            // 
            // QuyenQuanTriHeThong
            // 
            this.QuyenQuanTriHeThong.DataPropertyName = "QuyenQuanTriHeThong";
            this.QuyenQuanTriHeThong.FillWeight = 60.52921F;
            this.QuyenQuanTriHeThong.HeaderText = "Quản trị hệ thống";
            this.QuyenQuanTriHeThong.Name = "QuyenQuanTriHeThong";
            this.QuyenQuanTriHeThong.ReadOnly = true;
            // 
            // QuyenQuanLiNhanSu
            // 
            this.QuyenQuanLiNhanSu.DataPropertyName = "QuyenQuanLiNhanSu";
            this.QuyenQuanLiNhanSu.FillWeight = 51.5814F;
            this.QuyenQuanLiNhanSu.HeaderText = "Quản lý nhân sự";
            this.QuyenQuanLiNhanSu.Name = "QuyenQuanLiNhanSu";
            this.QuyenQuanLiNhanSu.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTTNVCoBanBindingSource
            // 
            this.tblTTNVCoBanBindingSource.DataMember = "TblTTNVCoBan";
            this.tblTTNVCoBanBindingSource.DataSource = this.dataSet1;
            // 
            // tblTTNVCoBanTableAdapter
            // 
            this.tblTTNVCoBanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            // 
            // frmphanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNS.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(857, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPhanQuyen);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmphanquyen";
            this.Text = "frmphanquyen";
            this.Load += new System.EventHandler(this.frmphanquyen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTNVCoBanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridPhanQuyen;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblTTNVCoBanBindingSource;
        private DataSet1TableAdapters.TblTTNVCoBanTableAdapter tblTTNVCoBanTableAdapter;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenDoiMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenQLCongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenQLTaiChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenQuanTriHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenQuanLiNhanSu;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton rbNVCongDoan;
        private System.Windows.Forms.RadioButton rbNVTaiChinh;
        private System.Windows.Forms.RadioButton rbNVPhongNhanSu;
        private System.Windows.Forms.RadioButton rbQuanTriVien;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Label label1;
    }
}