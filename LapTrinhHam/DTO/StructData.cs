using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHam.DTO
{
    public struct NHANVIEN
    {
        public string hoTen;
        public DateTime ngaySinh;
        public int tuoi;
    }
    public struct HOCSINH
    {
        public string hoTen;
        public double diemToan;
        public double diemVan;
        public double diemAnh;
        public double diemTB;
    }
    public struct MATHANG
    {
        public string tenMatHang;
        public string loaiMatHang;
        public int soLuong;
        public int donGia;
        public double tongTien;
    }
}
