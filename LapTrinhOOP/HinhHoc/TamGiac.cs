using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class TamGiac : HinhHoc
    {
        private Diem _diemA;
        private Diem _diemB;
        private Diem _diemC;

        internal Diem DiemA { get => _diemA; set => _diemA = value; }
        internal Diem DiemB { get => _diemB; set => _diemB = value; }
        internal Diem DiemC { get => _diemC; set => _diemC = value; }
        public override double ChuVi { get => this._tinhChuVi(); }
        public override double DienTich { get => this._tinhDienTich();}

        public TamGiac()
        {

        }
        public TamGiac(Diem d1, Diem d2, Diem d3)
        {
            this._diemA = d1;
            this._diemB = d2;
            this._diemC = d3;
        }

        private double _tinhDienTich()
        {
            double dienTich;

            DuongThang dAB = new DuongThang(this._diemA, this.DiemB);
            DuongThang dBC = new DuongThang(this._diemB, this.DiemC);
            DuongThang dCA = new DuongThang(this._diemC, this.DiemA);

            double nuaChuVi = this.ChuVi / 2;

            dienTich = Math.Sqrt(nuaChuVi*(nuaChuVi-dAB.ChieuDai) * (nuaChuVi - dBC.ChieuDai) * (nuaChuVi - dBC.ChieuDai));

            return dienTich;
        }
        private double _tinhChuVi()
        {
            double chuVi;

            DuongThang dAB = new DuongThang(this._diemA, this.DiemB);
            DuongThang dBC = new DuongThang(this._diemB, this.DiemC);
            DuongThang dCA = new DuongThang(this._diemC, this.DiemA);

            chuVi = dAB.ChieuDai + dBC.ChieuDai + dCA.ChieuDai;

            return chuVi;
        }
    }
}
