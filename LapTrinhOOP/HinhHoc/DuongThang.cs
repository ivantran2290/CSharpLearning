using System;
using System.Collections.Generic;
using System.Text;
using HuongThaoCore;

namespace LapTrinhOOP.HinhHoc
{
    public class DuongThang
    {
        private double _a;
        private double _b;
        private double _c;

        public double a { get => _a; set => _a = value; }
        public double b { get => _b; set => _b = value; }
        public double c { get => _c; set => _c = value; }
        public string PTTongQuat { get => _xuatPTTongQuat(); }
        public double GocVoiOx { get => _tinhGocVoiOx(); }
        public double HeSoGoc { get => -(_a / _b); }
        public ToaDo VTCP { get => new Vector(_a, _b); }
        public ToaDo VTPT { get => new Vector(-_b, a); }

        /// <summary>
        /// Khoi tao bang cach gan truc tiep tham so
        /// </summary>
        /// <param name="pa"></param>
        /// <param name="pb"></param>
        /// <param name="pc"></param>
        public DuongThang(double pa, double pb, double pc)
        {
            this._a = pa;
            this._b = pb;
            this._c = pc;
        }

        /// <summary>
        /// Khoi toa duong thang tu 2 diem
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        public DuongThang(Diem d1, Diem d2)
        {
            this._xacDinhPTTongQuatDuongThang(d1, d2);
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
            return Math.Acos(cosTheta);
        }

        private void _xacDinhPTTongQuatDuongThang(Diem diemDau, Diem diemCuoi)
        {
            if (diemDau.X == diemCuoi.X && diemDau.Y != diemCuoi.Y)
            {
                this.a = 1;
                this.b = 0;
                this.c = -diemDau.X;
            }
            else if (diemDau.X != diemCuoi.X && diemDau.Y == diemCuoi.Y)
            {
                this.a = 0;
                this.b = 1;
                this.c = -diemDau.Y;
            }
            else if (diemDau.X != diemCuoi.X && diemDau.Y != diemCuoi.Y)
            {
                double t = (diemDau.Y - diemCuoi.Y) / (diemDau.X - diemCuoi.X);
                double h = diemDau.Y - t * diemDau.X;
                this.a = -t;
                this.b = 1;
                this.c = -h;
            }
            else
            {
                this.a = this.b = this.c = 0;
            }
        }
        private string _xuatPTTongQuat()
        {            
            string rs;
            if(this._a == 0 && this._b != 0)
            {
                
                rs = string.Format("{0}y = {1}", this.b, -1 * this._c);
            }
            else if(this._b == 0 && this._a != 0)
            {
                rs = string.Format("{0}x = {1}", this.b, -1 * this._c);
            }
            else
            {
                rs = string.Format("{0}x {1}y = {2}", this._a, this._b > 0? "+ " + this._b.ToString(): this._b.ToString(), -1 * this._c);
            }
            return rs;
        }
        private void _doiDauSoAm()
        {
            if (this._a < 0)
            {
                this._a = this._a * -1;
                this._b = this._b * -1;
                this._c = this._c * -1;
            }
        }
        private string _dinhDang(double ts)
        {
            string tmp = ts == 1 || ts == -1 ? "" : ts.ToString();
            string dau = this.b < 0 ? "- " : "+ ";
            return dau + tmp;
        }
        private double _tinhGocVoiOx()
        {
            double goc = Math.Atan(this.HeSoGoc);
            goc = this.HeSoGoc > 0 ? goc : Math.PI + goc;
            return HTMath.RadToDegree(goc);
        }
    }
}