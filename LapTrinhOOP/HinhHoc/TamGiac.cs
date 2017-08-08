using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    class TamGiac : HinhHoc
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

            DoanThang dAB = new DoanThang(this._diemA, this.DiemB);
            DoanThang dBC = new DoanThang(this._diemB, this.DiemC);
            DoanThang dCA = new DoanThang(this._diemC, this.DiemA);

            double nuaChuVi = this.ChuVi / 2;

            dienTich = Math.Sqrt(nuaChuVi*(nuaChuVi-dAB.ChieuDai) * (nuaChuVi - dBC.ChieuDai) * (nuaChuVi - dBC.ChieuDai));

            return dienTich;
        }

        private double _tinhChuVi()
        {
            double chuVi;

            DoanThang dAB = new DoanThang(this._diemA, this.DiemB);
            DoanThang dBC = new DoanThang(this._diemB, this.DiemC);
            DoanThang dCA = new DoanThang(this._diemC, this.DiemA);

            chuVi = dAB.ChieuDai + dBC.ChieuDai + dCA.ChieuDai;

            return chuVi;
        }
    }
}
