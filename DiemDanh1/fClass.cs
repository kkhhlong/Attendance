using DiemDanh1.DAO;
using DiemDanh1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanh1
{
    public partial class fClass : Form
    {
        
        
        public fClass()
        {
            InitializeComponent();
            Loadd();
        }

        #region Method
        void Loadd()
        {
            labelThongBao.Text = "";
            txbClassName.Text = "";
            txbMaLop.Text = "";
        }
        bool dieuKienMaLop(string maLop)
        {
            List<Class> listClass = ClassDAO.Instance.LayDsClass();
            foreach (Class item in listClass)
            {
                if(maLop == item.MaLop)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Event
        private void bAdd_Click(object sender, EventArgs e)
        {

            string maLop = txbMaLop.Text;
            string tenLop = txbClassName.Text;
            if (string.IsNullOrWhiteSpace(maLop)) // MaLop = null
            {
                labelThongBao.Text = "Mã lớp không được trống";
                return;
            }
            if (!dieuKienMaLop(maLop)) //MaLop trùng tên
            {
                labelThongBao.Text = "Mã lớp " + txbMaLop.Text + " đã tồn tại";
                return;
            }
            if (string.IsNullOrWhiteSpace(tenLop))// Tên Lớp null
            {
                labelThongBao.Text = "Tên lớp không được trống";
                return;
            }

            if (ClassDAO.Instance.ThemLop(maLop, tenLop))
            {
                MessageBox.Show("Đã thêm lớp " + tenLop);
                Loadd();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm lớp " + tenLop);
                Loadd();
            }
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fClass_Load(object sender, EventArgs e)
        {

        }
    }

       

       
        #endregion
    
}
