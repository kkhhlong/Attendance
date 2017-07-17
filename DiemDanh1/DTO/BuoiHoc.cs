using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh1.DTO
{
   public class BuoiHoc
    {
        public BuoiHoc(int id,string maLop,DateTime ngayBuoiHoc)
        {
            Id = id;
            MaLop = maLop;
            NgayBuoiHoc = ngayBuoiHoc;
        }
        int id;
        string maLop;
        DateTime ngayBuoiHoc;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public DateTime NgayBuoiHoc
        {
            get
            {
                return ngayBuoiHoc;
            }

            set
            {
                ngayBuoiHoc = value;
            }
        }
        
    }
}
