namespace DiemDanh1
{
    partial class fThongTinSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTinSinhVien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSua = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lThongBao = new System.Windows.Forms.Label();
            this.txbmaLop = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbStudentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmssv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bSua
            // 
            this.bSua.BackColor = System.Drawing.Color.Indigo;
            this.bSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSua.ForeColor = System.Drawing.Color.White;
            this.bSua.Location = new System.Drawing.Point(1, 361);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(75, 42);
            this.bSua.TabIndex = 1;
            this.bSua.Text = "Sửa";
            this.bSua.UseVisualStyleBackColor = false;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // bXoa
            // 
            this.bXoa.BackColor = System.Drawing.Color.Indigo;
            this.bXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXoa.ForeColor = System.Drawing.Color.White;
            this.bXoa.Location = new System.Drawing.Point(92, 361);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(75, 42);
            this.bXoa.TabIndex = 2;
            this.bXoa.Text = "Xóa";
            this.bXoa.UseVisualStyleBackColor = false;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bThoat
            // 
            this.bThoat.BackColor = System.Drawing.Color.Indigo;
            this.bThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThoat.ForeColor = System.Drawing.Color.White;
            this.bThoat.Location = new System.Drawing.Point(182, 361);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(75, 42);
            this.bThoat.TabIndex = 3;
            this.bThoat.Text = "Thoát";
            this.bThoat.UseVisualStyleBackColor = false;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lThongBao);
            this.panel1.Controls.Add(this.txbmaLop);
            this.panel1.Controls.Add(this.bThoat);
            this.panel1.Controls.Add(this.bXoa);
            this.panel1.Controls.Add(this.txbTenLop);
            this.panel1.Controls.Add(this.bSua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbLop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbStudentName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbStudentCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(486, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 513);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lThongBao
            // 
            this.lThongBao.AutoSize = true;
            this.lThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThongBao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lThongBao.Location = new System.Drawing.Point(27, 9);
            this.lThongBao.Name = "lThongBao";
            this.lThongBao.Size = new System.Drawing.Size(12, 17);
            this.lThongBao.TabIndex = 25;
            this.lThongBao.Text = " ";
            // 
            // txbmaLop
            // 
            this.txbmaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmaLop.ForeColor = System.Drawing.Color.Indigo;
            this.txbmaLop.Location = new System.Drawing.Point(3, 63);
            this.txbmaLop.Name = "txbmaLop";
            this.txbmaLop.Size = new System.Drawing.Size(256, 23);
            this.txbmaLop.TabIndex = 24;
            this.txbmaLop.TextChanged += new System.EventHandler(this.txbmaLop_TextChanged);
            // 
            // txbTenLop
            // 
            this.txbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenLop.ForeColor = System.Drawing.Color.Indigo;
            this.txbTenLop.Location = new System.Drawing.Point(3, 110);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.ReadOnly = true;
            this.txbTenLop.Size = new System.Drawing.Size(256, 23);
            this.txbTenLop.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(-1, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(-1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Lớp";
            // 
            // txbLop
            // 
            this.txbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLop.ForeColor = System.Drawing.Color.Indigo;
            this.txbLop.Location = new System.Drawing.Point(3, 312);
            this.txbLop.Name = "txbLop";
            this.txbLop.Size = new System.Drawing.Size(256, 23);
            this.txbLop.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(-1, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thuộc lớp";
            // 
            // txbStudentName
            // 
            this.txbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentName.ForeColor = System.Drawing.Color.Indigo;
            this.txbStudentName.Location = new System.Drawing.Point(3, 247);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(256, 23);
            this.txbStudentName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(-1, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Họ Tên SV";
            // 
            // txbStudentCode
            // 
            this.txbStudentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentCode.ForeColor = System.Drawing.Color.Indigo;
            this.txbStudentCode.Location = new System.Drawing.Point(3, 185);
            this.txbStudentCode.Name = "txbStudentCode";
            this.txbStudentCode.Size = new System.Drawing.Size(256, 23);
            this.txbStudentCode.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(-3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Số SV";
            // 
            // txbmssv
            // 
            this.txbmssv.BackColor = System.Drawing.Color.Indigo;
            this.txbmssv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbmssv.Location = new System.Drawing.Point(33, 85);
            this.txbmssv.Name = "txbmssv";
            this.txbmssv.Size = new System.Drawing.Size(256, 13);
            this.txbmssv.TabIndex = 23;
            // 
            // fThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(770, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbmssv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThongTinSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbStudentCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmssv;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmaLop;
        private System.Windows.Forms.Label lThongBao;
    }
}