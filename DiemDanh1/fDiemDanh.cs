using DiemDanh1;
using DiemDanh1.DAO;
using DiemDanh1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace DiemDanh1
{
    public partial class fDiemDanh : Form
    {
        public fDiemDanh()
        {
            InitializeComponent();
            cbbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNgayHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbiD.DropDownStyle = ComboBoxStyle.DropDownList;
            Loadd();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HienThigrvKhongLag.DoubleBufferedd(dataGridView1, true);
        
            
       


        // set it to false if not needed



    }
        #region Method
        public static void ExportDataGridViewTo_Excel12(DataGridView myDataGridViewQuantity)
        {
            try
            {

                Excel_12.Application oExcel_12 = null; //Excel_12 Application 

                Excel_12.Workbook oBook = null; // Excel_12 Workbook 

                Excel_12.Sheets oSheetsColl = null; // Excel_12 Worksheets collection 

                Excel_12.Worksheet oSheet = null; // Excel_12 Worksheet 

                Excel_12.Range oRange = null; // Cell or Range in worksheet 

                Object oMissing = System.Reflection.Missing.Value;


                // Create an instance of Excel_12. 

                oExcel_12 = new Excel_12.Application();


                // Make Excel_12 visible to the user. 

                oExcel_12.Visible = true;


                // Set the UserControl property so Excel_12 won't shut down. 

                oExcel_12.UserControl = true;

                // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 

                //object file = File_Name;

                //object missing = System.Reflection.Missing.Value;



                // Add a workbook. 

                oBook = oExcel_12.Workbooks.Add(oMissing);

                // Get worksheets collection 

                oSheetsColl = oExcel_12.Worksheets;

                // Get Worksheet "Sheet1" 

                oSheet = (Excel_12.Worksheet)oSheetsColl.get_Item("Sheet1");
                oSheet.Name = "ChamCong";




                // Export titles 

                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {

                    oRange = (Excel_12.Range)oSheet.Cells[1, j + 1];

                    oRange.Value2 = "["+myDataGridViewQuantity.Columns[j].HeaderText+"]" ;

                }

                // Export data 

                for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
                {

                    for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                    {
                        oRange = (Excel_12.Range)oSheet.Cells[i + 2, j + 1];

                        oRange.Value2 = myDataGridViewQuantity[j, i].Value + "";

                    }

                }
                oBook = null;
                oExcel_12.Quit();
                oExcel_12 = null;
                GC.Collect();
            }
            catch(Exception)
            {

            }
        }
        void Loadd()
        {
            cbbNgayHoc.Items.Clear();
            cbbMaLop.Items.Clear();
            txbTenLop.Text = "";
            
            LayDsLop();

        }
       
        void HienThiGridView(string maLop)
        {
            List<DateTime> list = BuoiHocDAO.Instance.LayCacNgayHocCuaLop(maLop);
            
            dataGridView1.DataSource = BuoiHocDAO.Instance.BangDiemDanhLop(maLop, list);

        }
        void LayDsLop()
        {
            List<Class> listClass = ClassDAO.Instance.LayDsClass();
            foreach (Class item in listClass)
            {
                cbbMaLop.Items.Add(item.MaLop);
            }
            if(cbbMaLop.Items.Count > 0)
            {
               
                    cbbMaLop.SelectedIndex = 0;
               
            }
            else
            {
                MessageBox.Show("Hiện chưa có lớp nào, hãy thêm một lớp học","Thống báo");
            }

        }
       
        string LayTenLopTuMaLop(string maLop)
        {
            string tenLop = ClassDAO.Instance.LayTenLop(maLop);
            return tenLop;
        }
        void CapNhatNgayHoc(string maLop)
        {
            List<DateTime> ngayHoc = BuoiHocDAO.Instance.LayCacNgayHocCuaLop(maLop);
            cbbNgayHoc.Items.Clear();
            foreach (DateTime item in ngayHoc)
            {
                cbbNgayHoc.Items.Add(item);
                
            }
            if(ngayHoc.Count > 0)
            {
                cbbNgayHoc.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Chưa có buổi học cho lớp này");
            }
        }
        void CapNhatMSSVCuaLop(string maLop)
        {
            try
            {
                cbbiD.Items.Clear();
                foreach (string mssv in StudentDAO.Instance.LayDsMssvCuaMotLop(maLop))
                {
                    cbbiD.Items.Add(mssv);
                }
                cbbiD.SelectedIndex = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("Chưa có sinh viên cho lớp này");
            }
        }
        bool KiemTra(DateTime ngayHoc,string mssv)
        {
            return DiemDanhDAO.Instance.LayIdDiemDanh(ngayHoc,mssv) > 0;
        }
        int IdDiemDanh(DateTime ngayHoc, string mssv)
        {
            return DiemDanhDAO.Instance.LayIdDiemDanh(ngayHoc, mssv);
        }
        #endregion



        private void cbbNgayHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        
        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fClass lop = new fClass();
            lop.ShowDialog();
            Loadd();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSinhVien sinhVien = new fSinhVien();
            sinhVien.ShowDialog();
            Loadd();
        }

        private void thêmBuổiHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBuoiHoc buoiHoc = new fBuoiHoc();
            buoiHoc.ShowDialog();
            Loadd();
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string maLop = cbbMaLop.Text;
            txbTenLop.Text = LayTenLopTuMaLop(maLop);
            label2.Text = txbTenLop.Text;
            CapNhatNgayHoc(maLop);
            HienThiGridView(maLop);
        }

        private void bDiemDanh_Click(object sender, EventArgs e)
        {
            string maLop = cbbMaLop.Text;
            panel1.Enabled = true;
            lBuoi.Text = "Buổi " + (cbbNgayHoc.SelectedIndex + 1);
            cbbiD.Items.Clear();
            CapNhatMSSVCuaLop(maLop);
            
            
           
        }

        private void fDiemDanh_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbNgayHoc_TextChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void cbbiD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbiD.SelectedIndex == cbbiD.Items.Count - 1)
            {
                bnext.Text = "Finish";
            }
            else
            {
                bnext.Text = "Next";
            }
            if (cbbiD.SelectedIndex==0)
            {
                bpre.Enabled = false;
            }
            else
            {
                bpre.Enabled = true;
            }
            string[] t = StudentDAO.Instance.ThongTinSV(cbbiD.Text).Split('/');
            lName.Text = "Họ Tên: " + t[0];
            lLop.Text = "Lớp : " + t[1];
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            
            string maLop = cbbMaLop.Text;
            string mssv = cbbiD.Text;
            int trangThai = 1;
            if (cVang.Checked == true)
            {
                trangThai = 0;
            }
            if(cP.Checked == true)

            {
                trangThai = 2;
            }
            if (!KiemTra(Convert.ToDateTime(cbbNgayHoc.Text), mssv))
            {
               DiemDanhDAO.Instance.ThemSinhVienDiemDanh(mssv, Convert.ToDateTime(cbbNgayHoc.Text), trangThai);
            }
            else
            {
                if(MessageBox.Show("Sinh viên này đã điểm danh bạn có muốn sửa lại","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                DiemDanhDAO.Instance.SuaSinhVienDiemDanh(IdDiemDanh(Convert.ToDateTime(cbbNgayHoc.Text), mssv) , trangThai);
            }
            if (bnext.Text == "Finish")
            {
                HienThiGridView(cbbMaLop.Text);
                MessageBox.Show("Điểm danh xong");
            }
            else
            {
                cbbiD.SelectedIndex++;
                cDiHoc.Checked = true;
            }
            
        }

        private void bpre_Click(object sender, EventArgs e)
        {
            cbbiD.SelectedIndex -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportDataGridViewTo_Excel12(dataGridView1);
        }

        private void sửaTênLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinLop f = new fThongTinLop();
            f.ShowDialog();
            Loadd();
        }

        

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (panel1.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn chuyển ngày khi đang điểm danh", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return; 
            }
            for (int i = 0; i < cbbNgayHoc.Items.Count; i++)
            {
                if ((string.Format("{0:dd/MM/yyyy}", cbbNgayHoc.Items[i]) == dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString()))
                {
                    cbbNgayHoc.SelectedIndex = i;
                }
            }
        }

        private void sửaTênSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinSinhVien f = new fThongTinSinhVien();
            f.ShowDialog();
            Loadd();
        }
    }
}
