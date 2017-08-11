using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class HinhChuNhat : HinhTuGiac
    {
        public HinhChuNhat(Diem p1, Diem p2, Diem p3, Diem p4):base(p1, p2, p3, p4)
        {
        }

        public override double TinhDienTich()
        {
            //Dien tich hinh chu nhat
            return this.D1.ChieuDai * this.D2.ChieuDai;
        }
        public override double TinhChuVi()
        {
            //Chu vi hinh chu nhat
            return 2 * (this.D1.ChieuDai + this.D2.ChieuDai);
        }
    }
}
