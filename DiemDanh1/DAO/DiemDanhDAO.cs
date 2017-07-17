using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh1.DAO
{
    class DiemDanhDAO
    {
        private static DiemDanhDAO instance;

        public static DiemDanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemDanhDAO();
                return DiemDanhDAO.instance;
            }

            private set
            {
                DiemDanhDAO.instance = value;
            }
        }
        private DiemDanhDAO() { }
        public bool ThemSinhVienDiemDanh(string mssv , DateTime ngayHoc , int trangThai )
        
        {
            int result = 0;
            string query = "INSERT INTO dbo.DiemDanh( NgayHoc, Mssv, DiHoc)VALUES  ( @ngayHoc , @mssv , @trangThai )";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ngayHoc, mssv, trangThai });
            return result > 0;
        }
        public int LayIdDiemDanh(DateTime ngayHoc,string mssv)
        {
            string query = " EXEC dbo.USP_LayIdDiemDanh @mssv  , @ngayHoc ";
            try
            {
                return DataProvider.Instance.ExcuteScalar(query, new object[] { mssv, ngayHoc });
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public bool SuaSinhVienDiemDanh(int id , int trangThai)

        {
            int result = 0;
            string query = "UPDATE dbo.DiemDanh SET   DiHoc = @trangThai  WHERE id = @id ";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {  trangThai, id });
            return result > 0;
        }
       public int layDiemDanh(DateTime ngayHoc,string mssv)
        {
            if (kiemTraDiemDanh(ngayHoc, mssv))
            {
                string query = "EXEC dbo.USP_DanhSachDiemDanh @ngayHoc , @mssv ";
                return DataProvider.Instance.ExcuteScalar(query, new object[] { ngayHoc, mssv });
            }
            return -1;
        }
        public bool kiemTraDiemDanh(DateTime ngayHoc, string mssv)
        {
            string query = "EXEC dbo.USP_DanhSachDiemDanh @ngayHoc , @mssv ";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { ngayHoc , mssv });
            return dt.Rows.Count > 0;
        }

    }
}
