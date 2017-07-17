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

namespace DiemDanh1
{
    public partial class fThongTinSinhVien : Form
    {
        public fThongTinSinhVien()
        {
            InitializeComponent();
           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HienThigrvKhongLag.DoubleBufferedd(dataGridView1, true);
            Loadd();
        }
        bool KiemTraDieuKienMaSinhVien(string mssv) // Mssv không bị trùng
        {
            List<Student> listStudent = StudentDAO.Instance.LayDsSinhVien();
            foreach (Student item in listStudent)
            {
                if (mssv == item.Mssv)
                {
                    return false;

                }

            }
            return true;
        }
        void Loadd()
        {
            LayDSSV();
            DataBinding();
        }
        void DataBinding()
        {
            txbmssv.DataBindings.Clear();
            txbmssv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MSSV", true, DataSourceUpdateMode.Never));
            txbStudentCode.DataBindings.Clear();
            txbStudentCode.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MSSV",true,DataSourceUpdateMode.Never));
            txbStudentName.DataBindings.Clear();
            txbStudentName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ Tên", true, DataSourceUpdateMode.Never));
            txbLop.DataBindings.Clear();
            txbLop.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Thuộc Lớp", true, DataSourceUpdateMode.Never));
            txbmaLop.DataBindings.Clear();
            txbmaLop.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã Lớp Học", true, DataSourceUpdateMode.Never));
            txbTenLop.DataBindings.Clear();
            txbTenLop.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên Lớp Học", true, DataSourceUpdateMode.Never));
        }
        void LayDSSV()
        {
            dataGridView1.DataSource = StudentDAO.Instance.HienThiThongTinSinhVien();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbmaLop_TextChanged(object sender, EventArgs e)
        {
            txbTenLop.Text = ClassDAO.Instance.LayTenLop(txbmaLop.Text);
            if(txbTenLop.Text == "")
            {
                lThongBao.Text = "Chưa có lớp này trong dữ liệu";
                bSua.Enabled = false;
            }
            else
            {
                lThongBao.Text = "";
                bSua.Enabled = true;
            }
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            string maLop = txbmaLop.Text;
            string newMssv = txbStudentCode.Text;
            string hoTen = txbStudentName.Text;
            string idLop = txbLop.Text;
            string mssv = txbmssv.Text;
            
            if(string.IsNullOrWhiteSpace(mssv))
            {
                lThongBao.Text = "Vui lòng chọn sinh viên";
                return;
            }
            if (!KiemTraDieuKienMaSinhVien(newMssv))
            {
                if (newMssv != mssv)
                {
                    lThongBao.Text = newMssv + " đã tồn tại";
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(newMssv))
            {
                lThongBao.Text = "Mssv không để trống";
                return;
            }

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                lThongBao.Text = "Họ tên sinh viên không để trống";
                return;
            }
            if (string.IsNullOrWhiteSpace(idLop))
            {
                lThongBao.Text = "Lớp của sinh viên không để trống";
                return;
            }
            if(StudentDAO.Instance.SuaSinhVien(maLop,newMssv,hoTen,idLop,mssv))
            {
                lThongBao.Text = "Sửa thành công";
                Loadd();
            }
            else
            {
                lThongBao.Text = "Lỗi: Sửa thất bại. Thử lại";
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            string mssv = txbmssv.Text;
            if(MessageBox.Show("Ban có muốn xóa sinh viên "+mssv ,"Thông báo ",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            if (StudentDAO.Instance.XoaSinhVien( mssv))
            {
                lThongBao.Text = "Xóa thành công";
                Loadd();
            }
            else
            {
                lThongBao.Text = "Lỗi: Xóa thất bại. Thử lại";
            }
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
