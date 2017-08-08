using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.HinhHoc
{
    class DuongThang
    {
        private Diem _diemDau;
        private Diem _diemCuoi;

        public Diem DiemDau { get => _diemDau; set => _diemDau = value; }
        public Diem DiemCuoi { get => _diemCuoi; set => _diemCuoi = value; }
        public double ChieuDai { get => this._diemDau.KhoangCach(this._diemCuoi);}

        public DuongThang()
        {
        }
        public DuongThang(Diem d1, Diem d2)
        {
            this._diemDau = d1;
            this._diemCuoi = d2;
        }
        public void NhapDoanThang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this._diemDau.NhapToaDo();
            this._diemCuoi.NhapToaDo();
        }
        public void XuatDoanThang()
        {
            Console.WriteLine("Doan thang di qua 2 diem:");
            this._diemDau.XuatToaDo();
            this._diemCuoi.XuatToaDo();
        }
        public double TinhGoc(DuongThang d)
        {
            return 0;
        }
    }
}