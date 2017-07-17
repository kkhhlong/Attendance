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
    public partial class fThongTinLop : Form
    {
        public fThongTinLop()
        {
            InitializeComponent();
            cbbMaLop.DropDownStyle = ComboBoxStyle.DropDown;
            Loadd();
            
        }
        #region Method
        void Loadd()
        {
            cbbMaLop.Items.Clear();
            LayDsLop();
        }
        void LayDsLop()
        {
            List<Class> listClass = ClassDAO.Instance.LayDsClass();
            foreach (Class item in listClass)
            {
                cbbMaLop.Items.Add(item.MaLop);
            }
            if (cbbMaLop.Items.Count > 0)
            {

                cbbMaLop.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Hiện chưa có lớp nào, hãy thêm một lớp học", "Thống báo");
            }

        }
        #endregion
        private void fThongTinLop_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbbMaLop.Text;
            
           
            txbMaLop.Text = maLop;
            txbClassName.Text = ClassDAO.Instance.LayTenLop(maLop);
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbMaLop.Text) || string.IsNullOrWhiteSpace(txbClassName.Text))
            {
                labelThongBao.Text = "Mã lớp hoặc tên lớp không để trống";
                return;
            }
           
            int index = cbbMaLop.SelectedIndex;
            if(ClassDAO.Instance.SuaLop(cbbMaLop.Text,txbMaLop.Text,txbClassName.Text))
            {
                labelThongBao.Text = "Sửa thành công lớp " + txbClassName.Text;
                Loadd();
                if(cbbMaLop.Items.Count>0)
                    cbbMaLop.SelectedIndex = index;
               
                
            }
            else
            {
                labelThongBao.Text = "Lỗi: Sửa thất bại ";
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa lớp này không","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if(ClassDAO.Instance.XoaLop(cbbMaLop.Text))
                {
                    labelThongBao.Text = "Xóa thành công";
                    Loadd();
                }
                else
                {
                    labelThongBao.Text = "Có lỗi khi xóa";
                }
            }
        }
    }
}
