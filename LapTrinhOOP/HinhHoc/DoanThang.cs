using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class DoanThang:DuongThang
    {
        private Diem _diemDau;
        private Diem _diemCuoi;

        public double ChieuDai { get => _diemDau.KhoangCach(_diemCuoi); }
        public Diem DiemDau { get => _diemDau; }
        public Diem DiemCuoi { get => _diemCuoi; }
        public Diem TrungDiem { get => this.DiemDau.LayTrungDiem(DiemCuoi); }

        public DoanThang(Diem d1, Diem d2):base(d1, d2)
        {
            this._diemDau = d1;
            this._diemCuoi = d2;
        }
        public DuongThang TimDuongTrungTruc()
        {
            return new DuongThang(
                this.VTPT.X,
                this.VTPT.Y,
                -(this.VTPT.X*TrungDiem.X + this.VTPT.Y*TrungDiem.Y)
            );
        }
    }
}
