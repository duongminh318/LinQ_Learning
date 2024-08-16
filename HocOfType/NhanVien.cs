using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocOfType
{
    public class NhanVien
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public  virtual double TinhLuong()
        {
            return 5000000;
        }
    }
}
