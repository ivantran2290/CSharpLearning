using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.HinhHoc
{
    public class DuongThang
    {
        private Diem _diemDau;
        private Diem _diemCuoi;
        private double _a;
        private double _b;
        private double _c;

        public Diem DiemDau { get => _diemDau; set => _diemDau = value; }
        public Diem DiemCuoi { get => _diemCuoi; set => _diemCuoi = value; }
        public double ChieuDai { get => this._diemDau.KhoangCach(this._diemCuoi);}
        public double a { get => _a; set => _a = value; }
        public double b { get => _b; set => _b = value; }
        public double c { get => _c; set => _c = value; }
        public string PtTongQuat { get => string.Format("{0}x + {1}y + {2} = 0", this._a, this._b, this._c); }
        public double GocVoiOx { get => this._tinhGocVoiOx(); }
        public double HeSoGoc { get => -(this.a / this.b); }

        public DuongThang()
        {
        }
        public DuongThang(Diem d1, Diem d2)
        {
            this._diemDau = d1;
            this._diemCuoi = d2;
            this._ptTongQuatDuongThang();
        }
        public DuongThang(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }
        public void NhapDuongThang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this._diemDau.NhapToaDo();
            this._diemCuoi.NhapToaDo();
            this._ptTongQuatDuongThang();
        }
        public void XuatDuongThang()
        {
            Console.WriteLine("Doan thang di qua 2 diem:");
            this._diemDau.XuatToaDo();
            this._diemCuoi.XuatToaDo();
        }        
        public bool ChuaDiem(Diem d)
        {
            return this.a*d.X + this.b*d.Y + this.c == 0;
        }
        public double GocVoiDuongThang(DuongThang dt)
        {
            double tuSo = Math.Abs(this.a * dt.a + this.b * dt.b);
            double mauSo = (Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2))) * (Math.Sqrt(Math.Pow(dt.a, 2) + Math.Pow(dt.b, 2)));
            double cosTheta = tuSo / mauSo;
            return MathUtils.RadToDegree(Math.Acos(cosTheta));
        }

        private void _ptTongQuatDuongThang()
        {
            if (this.DiemDau.X == this.DiemCuoi.X && this.DiemDau.Y != this.DiemCuoi.Y)
            {
                this.a = 1;
                this.b = 0;
                this.c = -this.DiemDau.X;
            }
            else if (this.DiemDau.X != this.DiemCuoi.X && this.DiemDau.Y == this.DiemCuoi.Y)
            {
                this.a = 0;
                this.b = 1;
                this.c = -this.DiemDau.Y;
            }
            else if (this.DiemDau.X != this.DiemCuoi.X && this.DiemDau.Y != this.DiemCuoi.Y)
            {
                double t = (this.DiemDau.Y - this.DiemCuoi.Y) / (this.DiemDau.X - this.DiemCuoi.X);
                double h = DiemDau.Y - t * DiemDau.X;
                this.a = -t;
                this.b = 1;
                this.c = -h;
            }
            else
            {
                this.a = this.b = this.c = 0;
            }            
        }
        private double _tinhGocVoiOx()
        {
            double goc = Math.Atan(this.HeSoGoc);
            goc = this.HeSoGoc > 0 ? goc : Math.PI + goc;
            return MathUtils.RadToDegree(goc);
        }
    }
}