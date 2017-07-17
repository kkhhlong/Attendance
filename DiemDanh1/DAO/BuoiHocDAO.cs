using DiemDanh1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanh1.DAO
{
    public class BuoiHocDAO
    {
        static BuoiHocDAO instance;

        public static BuoiHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new BuoiHocDAO();
                return BuoiHocDAO.instance;
            }

            private set
            {
                BuoiHocDAO.instance = value;
            }
        }
        private BuoiHocDAO() { }
        public bool ThemBuoiHoc(string maLop, DateTime buoiHoc)
        {
            int result = 0;
            string query = "INSERT INTO dbo.BuoiHocCuaLop(idLop, BuoiHoc) VALUES( @maLop , @buoiHoc )"; // dung parameter.addwithvalue để giữ kiểu biến datetime
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLop, buoiHoc });
            return result > 0;
        }
        public List<BuoiHoc> LayDsBuoiHoc()
        {
            List<BuoiHoc> listBuoiHoc = new List<BuoiHoc>();
            string query = "select*from BuoiHocCuaLop";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    listBuoiHoc.Add(new BuoiHoc(Convert.ToInt32(item["id"]), item["idLop"].ToString(), Convert.ToDateTime(item["BuoiHoc"])));
                }
            }
            return listBuoiHoc;
        }
        public int SoDongDuLieu()
        {
            string query = "select count(*) from BuoiHocCuaLop";
            return DataProvider.Instance.ExcuteScalar(query);
        }
        public List<DateTime> LayCacNgayHocCuaLop(string maLop)
        {
            List<DateTime> ngayHoc = new List<DateTime>();
            string query = "EXEC USP_LayBuoiHocTheoLop @maLop";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { maLop });
            foreach (DataRow item in dt.Rows)
            {
                ngayHoc.Add(Convert.ToDateTime(item["BuoiHoc"]));
            }
            return ngayHoc;

        }
        public DataTable BangDiemDanhLop(string maLop, List<DateTime> list)
        {
            string query1 = "EXEC USP_ThongTinSinhVienMotLop @maLop";
            

            DataTable dt = DataProvider.Instance.ExcuteQuery(query1, new object[] { maLop });
            
            
            
            if (list.Count >0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dt.Columns.Add(string.Format("{0:dd/MM/yyyy}",list[i]));
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        switch (DiemDanhDAO.Instance.layDiemDanh(list[i], dt.Rows[row]["MSSV"].ToString()))
                        {
                            case 0:
                                dt.Rows[row][string.Format("{0:dd/MM/yyyy}", list[i])] = "v";
                                break;
                            case 1:
                                dt.Rows[row][string.Format("{0:dd/MM/yyyy}", list[i])] = "x";
                                break;
                            case 2:
                                dt.Rows[row][string.Format("{0:dd/MM/yyyy}", list[i])] = "p";
                                break;


                        }
                        
                    }
                }
            }
            return dt;

        }
    }

}
