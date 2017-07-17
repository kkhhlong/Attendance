using DiemDanh1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiemDanh1.DAO
{
   public class StudentDAO
    {
        static StudentDAO instance;

       public static StudentDAO Instance
        {
            get
            {
                if (instance == null) instance = new StudentDAO();
                return StudentDAO.instance;
            }

           private  set
            {
                StudentDAO.instance = value;
            }
        }
        private StudentDAO() { }
        public bool ThemSinhVien(string maLop,string mssv,string hoTen,string idLop)
        {
            int result = 0;

            string query = string.Format("INSERT INTO dbo.SinhVien(idLop, Mssv, HoTen, maLop)VALUES(N'{0}','{1}', N'{2}', N'{3}')", maLop,mssv,hoTen,idLop);
            result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<Student> LayDsSinhVien()
        {
            List<Student> listStudent = new List<Student>();
            string query = "select*from SinhVien";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    listStudent.Add(new Student(item["maLop"].ToString(),item["idLop"].ToString(), item["HoTen"].ToString(), item["Mssv"].ToString()));
                   
                }
            }
            return listStudent;
        }
        public List<string> LayDsMssvCuaMotLop(string maLop)
        {
            List<string> dsMssv = new List<string>();
           string query = " EXEC USP_MSSVCuMotLop @maLop";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { maLop });
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    dsMssv.Add(item[0].ToString());

                }
            }
            return dsMssv;
        }
        public DataTable LayDsSV( object[,] ds) // lay tu excel
        {
            DataTable dt = new DataTable();
            try
            {

                for (int row = 1; row <= ds.GetLength(1); row++)
                {
                    dt.Columns.Add(ds[1, row].ToString());
                }
                for (int column = 2; column <= ds.GetLength(0); column++)
                {
                    if (ds[column, 1] == null)
                    {
                        break;
                    }

                    DataRow dr = dt.NewRow();
                    for (int row = 1; row <= ds.GetLength(1); row++)
                    {

                        if (ds[column, row] != null)
                        {
                            dr[row - 1] = ds[column, row].ToString();
                        }
                        else
                        {
                            dr[row - 1] = "";
                        }




                    }
                    dt.Rows.Add(dr);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
            return dt;
        }
        public string ThemDsSv(string maLop,object[,] ds) //tra ve so sinh vien da them
        {
            string trangThai = "";
            DataTable dt = LayDsSV(ds);
           
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string mssv = dt.Rows[i][1].ToString();
                    string hoTen = dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString();
                    string idLop = dt.Rows[i][4].ToString();
                    if (!ThemSinhVien(maLop, mssv, hoTen, idLop))
                    {
                        trangThai += "Thêm sinh viên " + hoTen + "   " + mssv + " thất bại   \n";
                    }
                }
           
            
            return trangThai;
            
        }
        public string ThongTinSV(string mssv)
        {
            string kq = "";
            string query = "EXEC dbo.USP_ThongTinSinhVien @mssv";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query, new object[] { mssv });
            if(dt.Rows.Count > 0)
            {
                kq = dt.Rows[0]["HoTen"].ToString() + "/" + dt.Rows[0]["maLop"];
            }
            return kq;
        }
        public DataTable HienThiThongTinSinhVien()
        {
            string query = "EXEC USP_HienThiSinhVien";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            return dt;
        }
        public bool SuaSinhVien(string maLop,string newMssv,string hoTen,string idLop,string mssv)
        {
            int result = 0;
            string query = " UPDATE  dbo.SinhVien SET idLop = @maLop , Mssv = @newMssv , HoTen = @hoTen , maLop = @idLop WHERE Mssv = @mssv ";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLop, newMssv, hoTen, idLop, mssv });
            return result > 0;
        }
        public bool XoaSinhVien(string mssv)
        {
            int result = 0;
            string query = "DELETE FROM dbo.SinhVien WHERE Mssv = @mssv ";
            result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mssv });
            return result > 0;
        }
        
    }
}
