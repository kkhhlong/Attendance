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
    public partial class fBuoiHoc : Form
    {
        public fBuoiHoc()
        {
            InitializeComponent();
            cbbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            LayDsLop();
        }
        #region Method
        bool KiemTraBuoiHoc(string maLop,DateTime buoiHoc)
        {
            List<BuoiHoc> listBuoiHoc = BuoiHocDAO.Instance.LayDsBuoiHoc();
            foreach (BuoiHoc item in listBuoiHoc)
            {
                if(item.MaLop == maLop && item.NgayBuoiHoc == buoiHoc)
                {
                    return false;
                }
            }
            return true;
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
            if(maLop =="")
            {
                return "không tồn tại ";
            }
            string tenLop = ClassDAO.Instance.LayTenLop(maLop);
            return tenLop;
        }
        int ThemBuoiHoc(string maLop,DateTime buoiHoc)
        {
            if(!KiemTraBuoiHoc(maLop,buoiHoc))
            {
                MessageBox.Show(  "Lớp " + LayTenLopTuMaLop(maLop)+ " đã có buổi học ngày "+ string.Format("{0:dd/M/yyyy}", buoiHoc) );
                return 0;
            }
            if (!BuoiHocDAO.Instance.ThemBuoiHoc(maLop, buoiHoc))
            {
                MessageBox.Show("Thêm buổi học ngày " + string.Format("{0:dd/M/yyyy}", buoiHoc) + " của lớp " + LayTenLopTuMaLop(maLop) + " thất bại");
                return 0;
            }
            return 1;
               
           

        }
        int ThemLichHoc(string maLop)
        {
            string[] s = dateBegin.Text.Split('/');
            int dongDuLieu = 0;
            int dem = 0;
            for (DateTime i = new DateTime(Convert.ToInt32(s[2]), Convert.ToInt32(s[1]), Convert.ToInt32(s[0])); dem < numLessons.Value; i = i.AddDays(1))
            {
                if (cMon.Checked == true && "" + i.DayOfWeek == "Monday")
                {
                    dongDuLieu+=ThemBuoiHoc(maLop,i);
                    dem++;
                }
                if (cTue.Checked == true && "" + i.DayOfWeek == "Tuesday")
                {
                    dongDuLieu += ThemBuoiHoc(maLop, i);
                    dem++;
                }
                if (cWed.Checked == true && "" + i.DayOfWeek == "Wednesday")
                {
                    dongDuLieu += ThemBuoiHoc(maLop, i);
                    dem++;
                }
                if (cThu.Checked == true && "" + i.DayOfWeek == "Thursday")
                {
                    dongDuLieu += ThemBuoiHoc(maLop, i);
                    dem++;
                }
                if (cFri.Checked == true && "" + i.DayOfWeek == "Thursday")
                {
                    dongDuLieu += ThemBuoiHoc(maLop, i);
                    dem++;
                }
                if (cSat.Checked == true && "" + i.DayOfWeek == "Saturday")
                {
                    dongDuLieu += ThemBuoiHoc(maLop, i);
                    dem++;
                }
            }
            return dongDuLieu;
        }
        #endregion

        #region Event
        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTenLop.Text = LayTenLopTuMaLop(cbbMaLop.Text);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if(cbbMaLop.Text =="")
            {
                MessageBox.Show("Chọn lớp muốn thêm lịch học");
                return;
            }
           
            if (cMon.Checked == false && cTue.Checked == false && cWed.Checked == false && cThu.Checked == false && cFri.Checked == false && cSat.Checked == false && cMon.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn ngày học");
                return;
            }
            
            
            
            if (ThemLichHoc(cbbMaLop.Text) == 0) // số dòng thêm vô = 0 thì thêm thất bại
            {
                MessageBox.Show("Thêm lịch học cho lớp " + txbTenLop.Text + " thất bại");
            }
            else
            {
                MessageBox.Show("Đã thêm lịch học cho lớp " + txbTenLop.Text);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fBuoiHoc_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void txbTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void numLessons_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateBegin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
