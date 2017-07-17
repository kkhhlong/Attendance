namespace DiemDanh1
{
    partial class fBuoiHoc
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
            this.bCancel = new System.Windows.Forms.Button();
            this.lThongBao = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.numLessons = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cSat = new System.Windows.Forms.CheckBox();
            this.cFri = new System.Windows.Forms.CheckBox();
            this.cThu = new System.Windows.Forms.CheckBox();
            this.cWed = new System.Windows.Forms.CheckBox();
            this.cTue = new System.Windows.Forms.CheckBox();
            this.cMon = new System.Windows.Forms.CheckBox();
            this.ldate = new System.Windows.Forms.Label();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.labelTenLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLessons)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Indigo;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(373, 204);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(79, 38);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lThongBao
            // 
            this.lThongBao.AutoSize = true;
            this.lThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lThongBao.Location = new System.Drawing.Point(15, 243);
            this.lThongBao.Name = "lThongBao";
            this.lThongBao.Size = new System.Drawing.Size(13, 13);
            this.lThongBao.TabIndex = 19;
            this.lThongBao.Text = "  ";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Indigo;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(279, 204);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(79, 38);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // numLessons
            // 
            this.numLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLessons.ForeColor = System.Drawing.Color.Indigo;
            this.numLessons.Location = new System.Drawing.Point(18, 109);
            this.numLessons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLessons.Name = "numLessons";
            this.numLessons.Size = new System.Drawing.Size(158, 26);
            this.numLessons.TabIndex = 2;
            this.numLessons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLessons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLessons.ValueChanged += new System.EventHandler(this.numLessons_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số buổi học";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cSat);
            this.panel1.Controls.Add(this.cFri);
            this.panel1.Controls.Add(this.cThu);
            this.panel1.Controls.Add(this.cWed);
            this.panel1.Controls.Add(this.cTue);
            this.panel1.Controls.Add(this.cMon);
            this.panel1.Location = new System.Drawing.Point(225, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 150);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số ngày học tuần";
            // 
            // cSat
            // 
            this.cSat.AutoSize = true;
            this.cSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cSat.Location = new System.Drawing.Point(119, 114);
            this.cSat.Name = "cSat";
            this.cSat.Size = new System.Drawing.Size(64, 21);
            this.cSat.TabIndex = 13;
            this.cSat.Text = "Thứ 7";
            this.cSat.UseVisualStyleBackColor = true;
            // 
            // cFri
            // 
            this.cFri.AutoSize = true;
            this.cFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cFri.Location = new System.Drawing.Point(119, 69);
            this.cFri.Name = "cFri";
            this.cFri.Size = new System.Drawing.Size(64, 21);
            this.cFri.TabIndex = 12;
            this.cFri.Text = "Thứ 6";
            this.cFri.UseVisualStyleBackColor = true;
            // 
            // cThu
            // 
            this.cThu.AutoSize = true;
            this.cThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cThu.Location = new System.Drawing.Point(119, 26);
            this.cThu.Name = "cThu";
            this.cThu.Size = new System.Drawing.Size(64, 21);
            this.cThu.TabIndex = 11;
            this.cThu.Text = "Thứ 5";
            this.cThu.UseVisualStyleBackColor = true;
            // 
            // cWed
            // 
            this.cWed.AutoSize = true;
            this.cWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cWed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cWed.Location = new System.Drawing.Point(15, 114);
            this.cWed.Name = "cWed";
            this.cWed.Size = new System.Drawing.Size(64, 21);
            this.cWed.TabIndex = 10;
            this.cWed.Text = "Thứ 4";
            this.cWed.UseVisualStyleBackColor = true;
            // 
            // cTue
            // 
            this.cTue.AutoSize = true;
            this.cTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cTue.Location = new System.Drawing.Point(15, 69);
            this.cTue.Name = "cTue";
            this.cTue.Size = new System.Drawing.Size(64, 21);
            this.cTue.TabIndex = 9;
            this.cTue.Text = "Thứ 3";
            this.cTue.UseVisualStyleBackColor = true;
            // 
            // cMon
            // 
            this.cMon.AutoSize = true;
            this.cMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cMon.Location = new System.Drawing.Point(15, 26);
            this.cMon.Name = "cMon";
            this.cMon.Size = new System.Drawing.Size(64, 21);
            this.cMon.TabIndex = 8;
            this.cMon.Text = "Thứ 2";
            this.cMon.UseVisualStyleBackColor = true;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ldate.Location = new System.Drawing.Point(15, 13);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(136, 17);
            this.ldate.TabIndex = 13;
            this.ldate.Text = "Ngày bắt đầu học";
            // 
            // dateBegin
            // 
            this.dateBegin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBegin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBegin.Location = new System.Drawing.Point(15, 37);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(161, 23);
            this.dateBegin.TabIndex = 1;
            this.dateBegin.ValueChanged += new System.EventHandler(this.dateBegin_ValueChanged);
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelMaLop.Location = new System.Drawing.Point(14, 182);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(61, 17);
            this.labelMaLop.TabIndex = 3;
            this.labelMaLop.Text = "Mã Lớp";
            // 
            // txbTenLop
            // 
            this.txbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenLop.ForeColor = System.Drawing.Color.Indigo;
            this.txbTenLop.Location = new System.Drawing.Point(94, 222);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.ReadOnly = true;
            this.txbTenLop.Size = new System.Drawing.Size(162, 23);
            this.txbTenLop.TabIndex = 4;
            this.txbTenLop.TextChanged += new System.EventHandler(this.txbTenLop_TextChanged);
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop.ForeColor = System.Drawing.Color.Indigo;
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(94, 181);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(162, 24);
            this.cbbMaLop.TabIndex = 3;
            this.cbbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbbMaLop_SelectedIndexChanged);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTenLop.Location = new System.Drawing.Point(13, 223);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(68, 17);
            this.labelTenLop.TabIndex = 0;
            this.labelTenLop.Text = "Tên Lớp";
            // 
            // fBuoiHoc
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(507, 283);
            this.Controls.Add(this.txbTenLop);
            this.Controls.Add(this.labelTenLop);
            this.Controls.Add(this.labelMaLop);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.lThongBao);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.numLessons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.dateBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fBuoiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch học";
            this.Load += new System.EventHandler(this.fBuoiHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLessons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lThongBao;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.NumericUpDown numLessons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cSat;
        private System.Windows.Forms.CheckBox cFri;
        private System.Windows.Forms.CheckBox cThu;
        private System.Windows.Forms.CheckBox cWed;
        private System.Windows.Forms.CheckBox cTue;
        private System.Windows.Forms.CheckBox cMon;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.Label labelTenLop;
    }
}