using DiemDanh1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiemDanh1;

namespace DiemDanh1.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        public static ClassDAO Instance
        {
            get
            {
                if (instance == null) instance = new ClassDAO();
                return ClassDAO.instance;
            }

            private set
            {
                ClassDAO.instance = value;
            }
        }
        private ClassDAO() { }
        public bool ThemLop(string maLop , string tenLop)
        {
            string query = "INSERT INTO dbo.Lop(MaLop, TenLop)VALUES(N'"+maLop+"',N'"+tenLop+"')";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return  result>0;
           
        }
        public List<Class> LayDsClass()
        {
            List<Class> listClass = new List<Class>();
            string query = "Select*from Lop";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    listClass.Add(new Class(item["Malop"].ToString(), item["TenLop"].ToString()));
                }
            }
            return listClass;
        }
        public string LayTenLop(string maLop)
        {
            string tenLop = "";
            string query = "EXEC USP_LayTenLop @maLop";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query,new object[] { maLop });
            try
            {
                tenLop = "" + dt.Rows[0]["TenLop"];
            }
            catch(Exception)
            {

            }
            return tenLop;
        }
        public bool SuaLop(string maLop,string maLopMoi,string tenLop)
        {
            int result = 0;
            string query = " UPDATE dbo.Lop SET MaLop = @maLopMoi , TenLop = @tenLop WHERE MaLop = @maLop  ";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLopMoi, tenLop, maLop });
            return result > 0;
            
        }
        public bool XoaLop(string maLop)
        {
            int result = 0;
            string query = "DELETE FROM dbo.Lop WHERE MaLop = @maLop";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLop });
            return result > 0;
        }
    }
}
