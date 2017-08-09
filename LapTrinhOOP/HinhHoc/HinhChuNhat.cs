using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class HinhChuNhat : HinhHoc
    {
        private Diem _diemA;
        private Diem _diemB;
        private Diem _diemC;
        private Diem _diemD;

        internal Diem DiemA { get => _diemA; set => _diemA = value; }
        internal Diem DiemB { get => _diemB; set => _diemB = value; }
        internal Diem DiemC { get => _diemC; set => _diemC = value; }
        internal Diem DiemD { get => _diemD; set => _diemD = value; }
        public override double ChuVi { get => this._tinhChuVi(); }
        public override double DienTich { get => this._tinhDienTich(); }

        public HinhChuNhat()
        {

        }
        public HinhChuNhat(Diem d1, Diem d2, Diem d3, Diem d4)
        {
            this._diemA = d1;
            this._diemB = d2;
            this._diemC = d3;
            this._diemD = d4;
        }

        private double _tinhDienTich()
        {
            DuongThang dAB = new DuongThang(this._diemA, this.DiemB);
            DuongThang dBC = new DuongThang(this._diemB, this.DiemC);

            return dAB.ChieuDai * dBC.ChieuDai;
        }
        private double _tinhChuVi()
        {
            DuongThang dAB = new DuongThang(this._diemA, this.DiemB);
            DuongThang dBC = new DuongThang(this._diemB, this.DiemC);

            return 2*(dAB.ChieuDai + dBC.ChieuDai);
        }
    }
}
