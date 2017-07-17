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
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Data.Odbc;
using Office= Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel; // excel

namespace DiemDanh1
{
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
            LayDsLop();
            cbbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            tabControl2.Enabled = false;
           
            bAddt2.Enabled = false;
            
        }

        #region Method
        void ThemSVTuExcel(string path,string maLop)
        {
            try
            {
                var xlApp = new Excel.Application();
                xlApp.Visible = false;
                var xlWorkBook = xlApp.Workbooks.Open(path);
                var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets.get_Item(1);
                Excel.Range xlRange = xlWorkSheet.UsedRange;
                object[,] dt = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
                txbTrangThai.Text = StudentDAO.Instance.ThemDsSv(maLop, dt);
            }
            catch(Exception )
            {
                txbTrangThai.Text = "Excel không hợp lệ";
            }
            
            
             
            
            
        }
        void LayDsLop()
        {
            List<Class> listClass = ClassDAO.Instance.LayDsClass();
            foreach (Class item in listClass)
            {
                cbbMaLop.Items.Add(item.MaLop);
               
            }

        }
        
        string LayTenLopTuMaLop(string maLop)
        {
            string tenLop = ClassDAO.Instance.LayTenLop(maLop);
            return tenLop;
        }
        bool KiemTraDieuKienMaSinhVien(string mssv) // Mssv không bị trùng
        {
            List<Student> listStudent = StudentDAO.Instance.LayDsSinhVien();
            foreach (Student item in listStudent)
            {
                if(mssv == item.Mssv)
                {
                    return false;
                   
                }
               
            }
            return true;
        }
        #endregion

        #region Event
        

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenLop.Text = LayTenLopTuMaLop(cbbMaLop.Text);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string maLop = cbbMaLop.Text;
            string mssv = txbStudentCode.Text;
            string hoTen = txbStudentName.Text;
            string lop = txbLop.Text;
            if(!KiemTraDieuKienMaSinhVien(mssv))
            {
                labelThongBao.Text = "MSSV " + mssv + " đã tồn tại";
                return;
            }
            
            if(string.IsNullOrWhiteSpace(mssv))
            {
                labelThongBao.Text = "MSSV không được để trống";
                return;
            }
            if(string.IsNullOrWhiteSpace(hoTen))
            {
                labelThongBao.Text = "Tên sinh viên không để trống";
                return;
            }
            if (string.IsNullOrWhiteSpace(lop))
            {
                labelThongBao.Text = "Sinh viên thuộc lớp nào";
                return;
            }
            if (StudentDAO.Instance.ThemSinhVien(maLop,mssv,hoTen,lop))
            {
                labelThongBao.Text = "Đã thêm sinh viên " + hoTen;
                txbStudentName.Text = "";
            }
            else
            {
                labelThongBao.Text = "Thêm sinh viên " + hoTen+ " thất bại";
               
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

       

        private void fSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("http://daotao.huflit.edu.vn"); 
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "excel file (.xlsx)|*.xlsx|(.xls)|*.xls";
            
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                txbLink.Text = sfd.FileName;
            }

        }

        private void txbLink_TextChanged(object sender, EventArgs e)
        {
            if(txbLink.Text == "")
            {
                bAddt2.Enabled = false;
            }
            else
            {
                bAddt2.Enabled = true;
            }
        }

        private void bAddt2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ThemSVTuExcel(txbLink.Text, cbbMaLop.Text);
            if(txbTrangThai.Text =="")
            {
                txbTrangThai.Text = "Thêm thành công tất cả sinh viên";
            }
            Cursor.Current = Cursors.Default;
        }

        private void bChooseClass_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbbMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp");
            }
            else
            {
                tabControl2.Enabled = true;
            }
        }
        #endregion
    }
}
