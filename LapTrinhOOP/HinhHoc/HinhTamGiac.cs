using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class HinhTamGiac : HinhHoc
    {
        private Diem _p1;
        private Diem _p2;
        private Diem _p3;

        public Diem P1 { get => _p1; set => _p1 = value; }
        public Diem P2 { get => _p2; set => _p2 = value; }
        public Diem P3 { get => _p3; set => _p3 = value; }
        public override double ChuVi { get => _tinhChuVi(); }
        public override double DienTich { get => _tinhDienTich(); }
        public double D1 { get => _p1.KhoangCach(_p2); }
        public double D2 { get => _p2.KhoangCach(_p3); }
        public double D3 { get => _p3.KhoangCach(_p1); }

        public HinhTamGiac(Diem p1, Diem p2, Diem p3)
        {
            this._p1 = p1;
            this._p2 = p2;
            this._p3 = p3;
        }

        private double _tinhChuVi()
        {
            return this.D1 + this.D2 + this.D3;
        }
        private double _tinhDienTich()
        {
            // Tính nửa chu vi
            double nuaChuVi = this.ChuVi / 2;

            // Sử dụng công thức Heron
            return Math.Sqrt(nuaChuVi*(nuaChuVi-this.D1) * (nuaChuVi - this.D2) * (nuaChuVi - this.D3));
        }
    }
}
