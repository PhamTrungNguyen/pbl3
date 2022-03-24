namespace pbl3.Admin.DuLieu
{
    partial class LoaiManHinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgManHinh = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttxtManHinhTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManHinhMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnManHinhThem = new System.Windows.Forms.Button();
            this.BtnManHinhXoa = new System.Windows.Forms.Button();
            this.BtnManHinhXem = new System.Windows.Forms.Button();
            this.BtnManHinhSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManHinh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(386, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 639);
            this.panel1.TabIndex = 0;
            // 
            // dtgManHinh
            // 
            this.dtgManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgManHinh.Location = new System.Drawing.Point(0, 0);
            this.dtgManHinh.Name = "dtgManHinh";
            this.dtgManHinh.RowHeadersWidth = 62;
            this.dtgManHinh.RowTemplate.Height = 28;
            this.dtgManHinh.Size = new System.Drawing.Size(655, 639);
            this.dtgManHinh.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnManHinhXem);
            this.panel2.Controls.Add(this.txttxtManHinhTen);
            this.panel2.Controls.Add(this.BtnManHinhSua);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnManHinhXoa);
            this.panel2.Controls.Add(this.BtnManHinhThem);
            this.panel2.Controls.Add(this.txtManHinhMa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 639);
            this.panel2.TabIndex = 1;
            // 
            // txttxtManHinhTen
            // 
            this.txttxtManHinhTen.Location = new System.Drawing.Point(26, 166);
            this.txttxtManHinhTen.Name = "txttxtManHinhTen";
            this.txttxtManHinhTen.Size = new System.Drawing.Size(262, 35);
            this.txttxtManHinhTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên màn hình :";
            // 
            // txtManHinhMa
            // 
            this.txtManHinhMa.Location = new System.Drawing.Point(26, 47);
            this.txtManHinhMa.Name = "txtManHinhMa";
            this.txtManHinhMa.Size = new System.Drawing.Size(262, 35);
            this.txtManHinhMa.TabIndex = 1;
            this.txtManHinhMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại màn hình :";
            // 
            // BtnManHinhThem
            // 
            this.BtnManHinhThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhThem.Location = new System.Drawing.Point(49, 224);
            this.BtnManHinhThem.Name = "BtnManHinhThem";
            this.BtnManHinhThem.Size = new System.Drawing.Size(106, 45);
            this.BtnManHinhThem.TabIndex = 2;
            this.BtnManHinhThem.Text = "Thêm";
            this.BtnManHinhThem.UseVisualStyleBackColor = true;
            // 
            // BtnManHinhXoa
            // 
            this.BtnManHinhXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhXoa.Location = new System.Drawing.Point(163, 224);
            this.BtnManHinhXoa.Name = "BtnManHinhXoa";
            this.BtnManHinhXoa.Size = new System.Drawing.Size(106, 45);
            this.BtnManHinhXoa.TabIndex = 2;
            this.BtnManHinhXoa.Text = "Xóa";
            this.BtnManHinhXoa.UseVisualStyleBackColor = true;
            // 
            // BtnManHinhXem
            // 
            this.BtnManHinhXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhXem.Location = new System.Drawing.Point(49, 289);
            this.BtnManHinhXem.Name = "BtnManHinhXem";
            this.BtnManHinhXem.Size = new System.Drawing.Size(106, 45);
            this.BtnManHinhXem.TabIndex = 2;
            this.BtnManHinhXem.Text = "Xem";
            this.BtnManHinhXem.UseVisualStyleBackColor = true;
            // 
            // BtnManHinhSua
            // 
            this.BtnManHinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhSua.Location = new System.Drawing.Point(163, 289);
            this.BtnManHinhSua.Name = "BtnManHinhSua";
            this.BtnManHinhSua.Size = new System.Drawing.Size(106, 45);
            this.BtnManHinhSua.TabIndex = 2;
            this.BtnManHinhSua.Text = "Sửa";
            this.BtnManHinhSua.UseVisualStyleBackColor = true;
            // 
            // LoaiManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiManHinh";
            this.Size = new System.Drawing.Size(1041, 639);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgManHinh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgManHinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttxtManHinhTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManHinhMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnManHinhThem;
        private System.Windows.Forms.Button BtnManHinhXoa;
        private System.Windows.Forms.Button BtnManHinhXem;
        private System.Windows.Forms.Button BtnManHinhSua;
    }
}
