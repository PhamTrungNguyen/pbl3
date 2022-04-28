namespace pbl3.Admin.DuLieu
{
    partial class Phim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhimXem = new System.Windows.Forms.Button();
            this.btnPhimXoa = new System.Windows.Forms.Button();
            this.btnPhimSua = new System.Windows.Forms.Button();
            this.btnPhimThem = new System.Windows.Forms.Button();
            this.btnUpLoadPictureFilm = new System.Windows.Forms.Button();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.dtpPhimNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpPhimNgayKC = new System.Windows.Forms.DateTimePicker();
            this.txtPhimNamSX = new System.Windows.Forms.TextBox();
            this.txtPhimDaoDien = new System.Windows.Forms.TextBox();
            this.txtPhimSanXuat = new System.Windows.Forms.TextBox();
            this.txtPhimThoiLuong = new System.Windows.Forms.TextBox();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtPhimMoTa = new System.Windows.Forms.TextBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieDirector = new System.Windows.Forms.Label();
            this.lblMovieProductor = new System.Windows.Forms.Label();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.txtPhimTen = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtPhimMa = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTheLoai);
            this.panel2.Controls.Add(this.btnPhimXem);
            this.panel2.Controls.Add(this.btnPhimXoa);
            this.panel2.Controls.Add(this.btnPhimSua);
            this.panel2.Controls.Add(this.btnPhimThem);
            this.panel2.Controls.Add(this.btnUpLoadPictureFilm);
            this.panel2.Controls.Add(this.picFilm);
            this.panel2.Controls.Add(this.dtpPhimNgayKT);
            this.panel2.Controls.Add(this.dtpPhimNgayKC);
            this.panel2.Controls.Add(this.txtPhimNamSX);
            this.panel2.Controls.Add(this.txtPhimDaoDien);
            this.panel2.Controls.Add(this.txtPhimSanXuat);
            this.panel2.Controls.Add(this.txtPhimThoiLuong);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.txtPhimMoTa);
            this.panel2.Controls.Add(this.lblMovieYear);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieDirector);
            this.panel2.Controls.Add(this.lblMovieProductor);
            this.panel2.Controls.Add(this.lblMovieDesc);
            this.panel2.Controls.Add(this.txtPhimTen);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.txtPhimMa);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 260);
            this.panel2.TabIndex = 1;
            // 
            // btnPhimXem
            // 
            this.btnPhimXem.Location = new System.Drawing.Point(284, 217);
            this.btnPhimXem.Name = "btnPhimXem";
            this.btnPhimXem.Size = new System.Drawing.Size(81, 36);
            this.btnPhimXem.TabIndex = 57;
            this.btnPhimXem.Text = "Xem";
            this.btnPhimXem.UseVisualStyleBackColor = true;
            this.btnPhimXem.Click += new System.EventHandler(this.btnPhimXem_Click);
            // 
            // btnPhimXoa
            // 
            this.btnPhimXoa.Location = new System.Drawing.Point(197, 217);
            this.btnPhimXoa.Name = "btnPhimXoa";
            this.btnPhimXoa.Size = new System.Drawing.Size(81, 36);
            this.btnPhimXoa.TabIndex = 57;
            this.btnPhimXoa.Text = "Xóa";
            this.btnPhimXoa.UseVisualStyleBackColor = true;
            this.btnPhimXoa.Click += new System.EventHandler(this.btnPhimXoa_Click);
            // 
            // btnPhimSua
            // 
            this.btnPhimSua.Location = new System.Drawing.Point(110, 217);
            this.btnPhimSua.Name = "btnPhimSua";
            this.btnPhimSua.Size = new System.Drawing.Size(81, 36);
            this.btnPhimSua.TabIndex = 57;
            this.btnPhimSua.Text = "Sửa";
            this.btnPhimSua.UseVisualStyleBackColor = true;
            this.btnPhimSua.Click += new System.EventHandler(this.btnPhimSua_Click);
            // 
            // btnPhimThem
            // 
            this.btnPhimThem.Location = new System.Drawing.Point(23, 217);
            this.btnPhimThem.Name = "btnPhimThem";
            this.btnPhimThem.Size = new System.Drawing.Size(81, 36);
            this.btnPhimThem.TabIndex = 57;
            this.btnPhimThem.Text = "Thêm";
            this.btnPhimThem.UseVisualStyleBackColor = true;
            this.btnPhimThem.Click += new System.EventHandler(this.btnPhimThem_Click);
            // 
            // btnUpLoadPictureFilm
            // 
            this.btnUpLoadPictureFilm.Location = new System.Drawing.Point(1094, 289);
            this.btnUpLoadPictureFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            this.btnUpLoadPictureFilm.Size = new System.Drawing.Size(143, 51);
            this.btnUpLoadPictureFilm.TabIndex = 56;
            this.btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            this.btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            // 
            // picFilm
            // 
            this.picFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilm.Location = new System.Drawing.Point(1061, 2);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(209, 271);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 55;
            this.picFilm.TabStop = false;
            // 
            // dtpPhimNgayKT
            // 
            this.dtpPhimNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhimNgayKT.Location = new System.Drawing.Point(692, 196);
            this.dtpPhimNgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPhimNgayKT.Name = "dtpPhimNgayKT";
            this.dtpPhimNgayKT.Size = new System.Drawing.Size(226, 26);
            this.dtpPhimNgayKT.TabIndex = 53;
            // 
            // dtpPhimNgayKC
            // 
            this.dtpPhimNgayKC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhimNgayKC.Location = new System.Drawing.Point(692, 153);
            this.dtpPhimNgayKC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPhimNgayKC.Name = "dtpPhimNgayKC";
            this.dtpPhimNgayKC.Size = new System.Drawing.Size(226, 26);
            this.dtpPhimNgayKC.TabIndex = 52;
            // 
            // txtPhimNamSX
            // 
            this.txtPhimNamSX.Location = new System.Drawing.Point(692, 81);
            this.txtPhimNamSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimNamSX.Name = "txtPhimNamSX";
            this.txtPhimNamSX.Size = new System.Drawing.Size(188, 26);
            this.txtPhimNamSX.TabIndex = 50;
            // 
            // txtPhimDaoDien
            // 
            this.txtPhimDaoDien.Location = new System.Drawing.Point(692, 123);
            this.txtPhimDaoDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimDaoDien.Name = "txtPhimDaoDien";
            this.txtPhimDaoDien.Size = new System.Drawing.Size(188, 26);
            this.txtPhimDaoDien.TabIndex = 49;
            // 
            // txtPhimSanXuat
            // 
            this.txtPhimSanXuat.Location = new System.Drawing.Point(692, 42);
            this.txtPhimSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimSanXuat.Name = "txtPhimSanXuat";
            this.txtPhimSanXuat.Size = new System.Drawing.Size(188, 26);
            this.txtPhimSanXuat.TabIndex = 48;
            // 
            // txtPhimThoiLuong
            // 
            this.txtPhimThoiLuong.Location = new System.Drawing.Point(692, 2);
            this.txtPhimThoiLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimThoiLuong.Name = "txtPhimThoiLuong";
            this.txtPhimThoiLuong.Size = new System.Drawing.Size(188, 26);
            this.txtPhimThoiLuong.TabIndex = 47;
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(539, 196);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(111, 26);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(539, 153);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(115, 26);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(539, 0);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(133, 26);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // txtPhimMoTa
            // 
            this.txtPhimMoTa.Location = new System.Drawing.Point(168, 79);
            this.txtPhimMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimMoTa.Multiline = true;
            this.txtPhimMoTa.Name = "txtPhimMoTa";
            this.txtPhimMoTa.Size = new System.Drawing.Size(164, 26);
            this.txtPhimMoTa.TabIndex = 46;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYear.Location = new System.Drawing.Point(539, 79);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(103, 26);
            this.lblMovieYear.TabIndex = 41;
            this.lblMovieYear.Text = "Năm SX:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(17, 118);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(103, 26);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieDirector
            // 
            this.lblMovieDirector.AutoSize = true;
            this.lblMovieDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDirector.Location = new System.Drawing.Point(539, 116);
            this.lblMovieDirector.Name = "lblMovieDirector";
            this.lblMovieDirector.Size = new System.Drawing.Size(111, 26);
            this.lblMovieDirector.TabIndex = 39;
            this.lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieProductor
            // 
            this.lblMovieProductor.AutoSize = true;
            this.lblMovieProductor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieProductor.Location = new System.Drawing.Point(539, 36);
            this.lblMovieProductor.Name = "lblMovieProductor";
            this.lblMovieProductor.Size = new System.Drawing.Size(109, 26);
            this.lblMovieProductor.TabIndex = 38;
            this.lblMovieProductor.Text = "Sản xuất:";
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDesc.Location = new System.Drawing.Point(15, 73);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(81, 26);
            this.lblMovieDesc.TabIndex = 37;
            this.lblMovieDesc.Text = "Mô tả:";
            // 
            // txtPhimTen
            // 
            this.txtPhimTen.Location = new System.Drawing.Point(168, 42);
            this.txtPhimTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimTen.Name = "txtPhimTen";
            this.txtPhimTen.Size = new System.Drawing.Size(164, 26);
            this.txtPhimTen.TabIndex = 51;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(15, 35);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(117, 26);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtPhimMa
            // 
            this.txtPhimMa.Location = new System.Drawing.Point(168, 0);
            this.txtPhimMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimMa.Name = "txtPhimMa";
            this.txtPhimMa.Size = new System.Drawing.Size(164, 26);
            this.txtPhimMa.TabIndex = 45;
            this.txtPhimMa.TextChanged += new System.EventHandler(this.txtPhimMa_TextChanged);
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(17, 2);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(113, 26);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 382);
            this.panel1.TabIndex = 2;
            // 
            // dgvMovie
            // 
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.RowHeadersWidth = 62;
            this.dgvMovie.RowTemplate.Height = 28;
            this.dgvMovie.Size = new System.Drawing.Size(1066, 382);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMovie_RowHeaderMouseClick);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(168, 120);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(164, 28);
            this.cboTheLoai.TabIndex = 58;
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Phim";
            this.Size = new System.Drawing.Size(1066, 642);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpLoadPictureFilm;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.DateTimePicker dtpPhimNgayKT;
        private System.Windows.Forms.DateTimePicker dtpPhimNgayKC;
        private System.Windows.Forms.TextBox txtPhimNamSX;
        private System.Windows.Forms.TextBox txtPhimDaoDien;
        private System.Windows.Forms.TextBox txtPhimSanXuat;
        private System.Windows.Forms.TextBox txtPhimThoiLuong;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.TextBox txtPhimMoTa;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieDirector;
        private System.Windows.Forms.Label lblMovieProductor;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox txtPhimTen;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtPhimMa;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Button btnPhimXem;
        private System.Windows.Forms.Button btnPhimXoa;
        private System.Windows.Forms.Button btnPhimSua;
        private System.Windows.Forms.Button btnPhimThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.ComboBox cboTheLoai;
    }
}
