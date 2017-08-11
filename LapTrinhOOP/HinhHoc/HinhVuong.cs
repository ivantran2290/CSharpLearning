using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong(Diem p1, Diem p2, Diem p3, Diem p4):base(p1, p2, p3, p4)
        {
        }

        public override double TinhChuVi()
        {
            //Chu vi hinh vuong
            return 4 * this.D1.ChieuDai;
        }
    }
}