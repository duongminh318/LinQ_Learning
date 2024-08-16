using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocOfType
{
    public class NhanVienChinhThuc:NhanVien
    {
        public override double TinhLuong()
        {
            return base.TinhLuong()+700000;
        }
    }
}
