using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh1.DTO
{
   public  class Student
    {
        public Student(string idLop,string maLop,string hoTen,string mssv)
        {
            IdLop = idLop;
            MaLop = maLop;
            HoTen = hoTen;
            Mssv = mssv;
        }
        string idLop;
        string maLop;
        string hoTen;
        string mssv;

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string Mssv
        {
            get
            {
                return mssv;
            }

            set
            {
                mssv = value;
            }
        }

        public string IdLop
        {
            get
            {
                return idLop;
            }

            set
            {
                idLop = value;
            }
        }
    }
}
