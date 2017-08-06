using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhCoBan.DTO
{
    struct NHANVIEN
    {
        public string hoTen;
        public DateTime ngaySinh;
        public int tuoi;
    }
    struct HOCSINH
    {
        public string hoTen;
        public double diemToan;
        public double diemVan;
        public double diemAnh;
        public double diemTB;
    }
    struct MATHANG
    {
        public string tenMatHang;
        public string loaiMatHang;
        public int soLuong;
        public int donGia;
        public double tongTien;
    }
}
