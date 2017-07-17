using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiemDanh1.DAO;

namespace DiemDanh1.DTO
{
    public class Class
    {
        public Class(string maLop , string TenLop)
        {
            MaLop = maLop;
            TenLop = tenLop;
        }
        string maLop;

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

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        string tenLop;
    }
}
