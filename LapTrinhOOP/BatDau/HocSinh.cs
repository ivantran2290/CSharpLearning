using System;
using System.Collections.Generic;
using System.Text;
using HuongThaoCore;

namespace LapTrinhOOP.BatDau
{
    public class HocSinh
    {
        private string _hoTen;
        private GioiTinh _gioiTinh;
        private DateTime _ngaySinh;
        private double _diemToan;
        private double _diemVan;
        private double _diemAnh;

        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public double DiemToan { get => _diemToan; set => _diemToan = value; }
        public double DiemVan { get => _diemVan; set => _diemVan = value; }
        public double DiemAnh { get => _diemAnh; set => _diemAnh = value; }
        public double DiemTrungBinh { get => (_diemToan * 2 + _diemVan * 2 + _diemAnh) / 5;}
        public double Tuoi { get => HTCommon.TinhTuoi(_ngaySinh); }
        public GioiTinh GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }

        public void NhapThongTin()
        {
            Console.WriteLine("------Nhap thong tin hoc sinh------");

            _hoTen = HTConnsole.NhapChuoi("Nhap ho ten: ");
            _ngaySinh = HTConnsole.NhapNgay("Nhap ngay sinh: ");

            Console.Write("Gioi tinh (1/0): ");
            _gioiTinh = (GioiTinh)Enum.Parse(typeof(GioiTinh), Console.ReadLine());
        }
        public void NhapKetQuaHocTap()
        {
            Console.WriteLine("------Nhap ket qua hoc tap------");

            _diemToan = HTConnsole.NhapSoThuc("Nhap diem Toan: ");
            _diemVan  = HTConnsole.NhapSoThuc("Nhap diem Van: ");
            _diemAnh  = HTConnsole.NhapSoThuc("Nhap diem Anh: ");
        }
        public void XuatKetQuaHocTap()
        {
            Console.WriteLine("--------Ket qua hoc tap--------");
            Console.WriteLine("Ho ten       : {0}", HoTen);
            Console.WriteLine("Tuoi         : {0}", Tuoi);
            Console.WriteLine("Gioi tinh    : {0}", GioiTinh);
            Console.WriteLine("Diem Toan    : {0}", DiemToan);
            Console.WriteLine("Diem Van     : {0}", DiemVan);
            Console.WriteLine("Diem Anh     : {0}", DiemAnh);
            Console.WriteLine("Diem TB      : {0}", DiemTrungBinh);
        }
    }    
}
