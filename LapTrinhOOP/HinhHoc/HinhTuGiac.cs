using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class HinhTuGiac : HinhHoc
    {
        protected Diem _p1;
        protected Diem _p2;
        protected Diem _p3;
        protected Diem _p4;

        public Diem P1 { get => _p1; set => _p1 = value; }
        public Diem P2 { get => _p2; set => _p2 = value; }
        public Diem P3 { get => _p3; set => _p3 = value; }
        public Diem P4 { get => _p4; set => _p4 = value; }
        public DoanThang D1 { get => new DoanThang(_p1, _p2); }
        public DoanThang D2 { get => new DoanThang(_p2, _p3); }
        public DoanThang D3 { get => new DoanThang(_p3, _p4); }
        public DoanThang D4 { get => new DoanThang(_p4, _p1); }
        public override double ChuVi { get => TinhChuVi(); }
        public override double DienTich { get => TinhDienTich(); }
        public LoaiHinhTuGiac LoaiHinhTG { get => _kiemTraLoaiHinh(); }

        public HinhTuGiac(Diem p1, Diem p2, Diem p3, Diem p4)
        {
            this._p1 = p1;
            this._p2 = p2;
            this._p3 = p3;
            this._p4 = p4;
        }

        public virtual double TinhDienTich()
        {
            //Dinh nghia lai
            return 0;
        }
        public virtual double TinhChuVi()
        {
            //Dinh nghia lai
            return 0;
        }
        private LoaiHinhTuGiac _kiemTraLoaiHinh()
        {
            if(this.D1.GocVoiDuongThang(this.D2) == Math.PI / 2
                && this.D2.GocVoiDuongThang(this.D3) == Math.PI/2)
            {
                if (this.D1.ChieuDai == this.D2.ChieuDai)
                {
                    return LoaiHinhTuGiac.HinhVuong;
                }
                return LoaiHinhTuGiac.HinhChuNhat;
            }
            else
            {
                return LoaiHinhTuGiac.HinhTuGiac;
            }
        }
    }
    public enum LoaiHinhTuGiac
    {
        HinhChuNhat = 1,
        HinhVuong = 2,
        HinhTuGiac
    }
}