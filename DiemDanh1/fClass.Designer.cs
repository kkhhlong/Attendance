namespace DiemDanh1
{
    partial class fClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbClassName = new System.Windows.Forms.TextBox();
            this.lTenLop = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMaLop = new System.Windows.Forms.TextBox();
            this.lMaLop = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbClassName);
            this.panel1.Controls.Add(this.lTenLop);
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 54);
            this.panel1.TabIndex = 2;
            // 
            // txbClassName
            // 
            this.txbClassName.Location = new System.Drawing.Point(122, 17);
            this.txbClassName.Name = "txbClassName";
            this.txbClassName.Size = new System.Drawing.Size(289, 20);
            this.txbClassName.TabIndex = 2;
            // 
            // lTenLop
            // 
            this.lTenLop.AutoSize = true;
            this.lTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lTenLop.Location = new System.Drawing.Point(19, 17);
            this.lTenLop.Name = "lTenLop";
            this.lTenLop.Size = new System.Drawing.Size(74, 20);
            this.lTenLop.TabIndex = 0;
            this.lTenLop.Text = "Tên Lớp";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Indigo;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(212, 119);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(90, 30);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Indigo;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(322, 119);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 30);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaLop);
            this.panel2.Controls.Add(this.lMaLop);
            this.panel2.Location = new System.Drawing.Point(1, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 54);
            this.panel2.TabIndex = 1;
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(122, 17);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(289, 20);
            this.txbMaLop.TabIndex = 1;
            // 
            // lMaLop
            // 
            this.lMaLop.AutoSize = true;
            this.lMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lMaLop.Location = new System.Drawing.Point(19, 17);
            this.lMaLop.Name = "lMaLop";
            this.lMaLop.Size = new System.Drawing.Size(68, 20);
            this.lMaLop.TabIndex = 0;
            this.lMaLop.Text = "Mã Lớp";
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelThongBao.Location = new System.Drawing.Point(123, 13);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(11, 16);
            this.labelThongBao.TabIndex = 5;
            this.labelThongBao.Text = " ";
            // 
            // fClass
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(432, 167);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Lớp";
            this.Load += new System.EventHandler(this.fClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbClassName;
        private System.Windows.Forms.Label lTenLop;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMaLop;
        private System.Windows.Forms.Label lMaLop;
        private System.Windows.Forms.Label labelThongBao;
    }
}