using System;
using System.Linq;
using LapTrinhCoBan.DTO;

namespace LenhCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChuongTrinhDauTien();

            //TinhCanBacHai();

            //TinhDiemTrungBinh();

            //TinhTienBanHang();

            //ChuongTrinh_TinhSoNgayGuiTietKiem();

            //ChuongTrinh_SoNgayLamViecConLaiTruocKhiVeHuu();

            //ChuongTrinh_TinhKhoangCachGiuaDiemVaDuongThang();

            //ChuongTrinh_TinhTongCacChuSoCuaSoBatKi();

            //ChuongTrinh_TinhTuoiSuDungBienCauTruc();

            //ChuongTrinh_TinhGiamGiaCoDieuKien();

            //ChuongTrinh_TinhTienTaxi();

            //ChuongTrinh_TinhTienDien();

            //ChuongTrinh_XuLyMang();

            //ChuongTrinh_TinhKetQuaHocTap();

            //ChuongTrinh_XuLyMangNangCao();

            //ChuongTrinh_XuLyMang_Nhom_1();

            //ChuongTrinh_XuLyMang_Nhom_2();

            //ChuongTrinh_XuLyMang_Nhom_3();

            //ChuongTrinh_XuLyMang_Nhom_4();

            //ChuongTrinh_TinhTienBanHangCoDieuKien();

            ChuongTrinh_TimThu6Ngay13();

        }

        static void ChuongTrinh_DauTien()
        {
            // Lenh khai bao bien
            int m;
            double x;
            string Ho_Ten;
            string Chuoi_m;
            string Chuoi_x;

            // Lenh nhap lieu
            Console.Write("Nhap vao chuoi: ");
            Ho_Ten = Console.ReadLine();

            Console.Write("Nhap vao so nguyen: ");
            Chuoi_m = Console.ReadLine();
            m = int.Parse(Chuoi_m);

            Console.Write("Nhap vao so thuc: ");
            Chuoi_x = Console.ReadLine();
            x = double.Parse(Chuoi_x);

            // Lenh xu ly
            int n = m + 4;

            // Lenh ket xuat
            Console.WriteLine("------------------Ket qua nhap lieu nhu ben duoi-----------------");
            Console.WriteLine("Chuoi: " + Ho_Ten);
            Console.WriteLine("So nguyen: " + m);
            Console.WriteLine("So thuc: " + x);
        }

        static void ChuongTrinh_TinhCanBacHai()
        {
            // Khai bao so thuc x
            double x;

            // Khai bao so thuc y
            double y;

            // Nhap lieu cho x
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());

            // Tinh y
            y = Math.Sqrt(x);

            // Xuat ket qua cua y
            Console.WriteLine("y=" + Math.Round(y, 2));
        }        

        static void ChuongTrinh_TinhTienBanHang()
        {
            // Khai bao bien so nguyen so luong
            int soLuong;

            // Khai bao bien so thuc don gia
            double donGia;

            // Khai bao bien so thuc tong tien
            double tongTien;

            // Nhap lieu cho so luong
            Console.Write("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());

            // Nhap lieu cho don gia
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());

            // Xu ly tinh tien
            tongTien = soLuong * donGia;

            // Xuat ket qua tinh tien
            Console.WriteLine("Tong tien cua hoa don la: " + Math.Round(tongTien, 2));
        }

        static void ChuongTrinh_TinhDiemTrungBinh()
        {
            // Khai bao bien chuoi Ho Ten
            string hoTen;

            // Khai bao bien so thuc Toan
            double diemToan;

            // Khai bao bien so thuc Van
            double diemVan;

            // Khai bao bien so thuc Anh Van
            double diemAnh;

            // Khai bao bien so thuc Diem Trung Binh
            double diemTrungBinh;

            // Nhap lieu cho Ho Ten
            Console.Write("Nhap Ho Ten: ");
            hoTen = Console.ReadLine();

            // Nhap lieu cho Toan
            Console.Write("Nhap diem Toan: ");
            diemToan = double.Parse(Console.ReadLine());

            // Nhap lieu cho Van
            Console.Write("Nhap diem Van: ");
            diemVan = double.Parse(Console.ReadLine());

            // Nhap lieu cho Anh Van
            Console.Write("Nhap diem Anh Van: ");
            diemAnh = double.Parse(Console.ReadLine());

            // Xu ly tinh diem trung binh
            diemTrungBinh = (diemToan * 2 + diemVan * 2 + diemAnh) / 5;

            // Xuat diem trung binh ra man hinh
            Console.WriteLine("Diem trung binh cua ban la:" + Math.Round(diemTrungBinh, 2));
        }

        static void ChuongTrinh_TinhTuoiNhanVien()
        {
            // Khai bao bien chuoi ho ten
            string hoTen;

            // Khai bao bien ngay ngay sinh nhan vien
            DateTime ngaySinh;

            // Khai bao bien ngay ngay hien hanh
            DateTime ngayHienHanh;

            // Nhap ho ten nhan vien
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();

            // Nhap ngay sinh nhan vien
            Console.Write("Ngay sinh format MM/DD/YYYY: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());

            // Tinh nam hien hanh
            ngayHienHanh = DateTime.Now;

            // Tinh tuoi nhan vien

            // Xuat tuoi nhan vien
        }

        static void ChuongTrinh_TinhSoNgayGuiTietKiem()
        {
            // Khai bao bien chuoi ho ten
            string hoTen;

            // Khai bao bien ngay ngay gui
            DateTime ngayGui;

            // Khai bao bien ngay ngay rut
            DateTime ngayRut;

            // Nhap ho ten
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            // Nhap ngay gui
            Console.Write("Nhap ngay gui theo dinh dang MM/DD/YYYY: ");
            ngayGui = DateTime.Parse(Console.ReadLine());

            // Nhap ngay rut
            Console.Write("Nhap ngay rut theo dinh dang MM/DD/YYYY: ");
            ngayRut = DateTime.Parse(Console.ReadLine());

            // Xu ly tinh so ngay gui
            TimeSpan thoiGianGui = ngayRut.Subtract(ngayGui);

            // Xuat so ngay gui
            Console.WriteLine("So ngay da gui tiet kiem: " + thoiGianGui.Days);
        }

        static void ChuongTrinh_SoNgayLamViecConLaiTruocKhiVeHuu()
        {
            //Khai bao bien nhap: 
            string hoTen;       //chuoi ho ten
            DateTime ngaySinh;  //ngay ngay sinh

            //Khai bao bien xuat: 
            int soNamConLaiTruocKhiVeHuu;       //So nguyen, so nam con lai truoc khi ve huu
            int soThangConLaiTruocKhiVeHuu;     //So nguyen, so thang con lai truoc khi ve huu
            int soNgayConLaiTruocKhiVeHuu;      //So nguyen, so ngay con lai truoc khi ve huu

            //Khai bao bien xu ly:
            int ngayCuaNgaySinh;    //So nguyen, so thu tu ngay trong ngay sinh
            int thangCuaNgaySinh;   //So nguyen, so thu tu thang trong ngay sinh 
            int namCuaNgaySinh;     //so nguyen, so thu tu nam trong ngay sinh

            int ngayCuaNgayVeHuu;   //so nguyen, so thu tu nam cua ngay ve huu
            int thangCuaNgayVeHuu;  //so nguyen, so thu tu thang cua ngay ve huu
            int namCuaNgayVeHuu;    //so nguyen, so thu tu ngay cua ngay ve huu

            DateTime ngayVeHuu;     //ngay, ngay ve huu
            DateTime ngayHienTai;   //ngay, ngay hien tai

            TimeSpan thoiGianConLaiTruocKhiVeHuu;       //Timespane, thoi gian con lai

            //Nhap lieu cho ho ten
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();

            //Nhap lieu cho ngay sinh
            Console.Write("Nhap ngay sinh: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());

            //Xu ly du lieu: 
            ngayCuaNgaySinh = ngaySinh.Day;     //so thu tu ngay trong ngay sinh = lay ngay trong ngay sinh
            thangCuaNgaySinh = ngaySinh.Month;  //so thu tu thang trong ngay sinh = lay thang trong ngay sinh
            namCuaNgaySinh = ngaySinh.Year;     //so thu tu nam trong ngay sinh = lay nam trong ngay sinh

            
            ngayCuaNgayVeHuu = ngayCuaNgaySinh;     //so thu tu ngay ve huu = so thu tu ngay trong ngay sinh
            thangCuaNgayVeHuu = thangCuaNgaySinh;   //so thu tu thang ve huu = so thu tu thang trong ngay sinh
            namCuaNgayVeHuu = namCuaNgaySinh + 60;  //so thu tu nam ve huu = so thu tu nam trong ngay sinh + 60

            //Tinh ngay ve huu = so thu tu ngay ve huu vs so thu tu thang ve huu vs so thu tu nam ve huu
            ngayVeHuu = new DateTime(namCuaNgayVeHuu, thangCuaNgayVeHuu, ngayCuaNgayVeHuu);

            //Lay ngay hien tai
            ngayHienTai = DateTime.Today;   
            
            thoiGianConLaiTruocKhiVeHuu = ngayVeHuu - ngayHienTai;          //(Timespan) thoi gian con lai = ngay ve huu - ngay hien tai
            soNgayConLaiTruocKhiVeHuu = thoiGianConLaiTruocKhiVeHuu.Days;   //(Days) so ngay con lai = so ngay trong thoi gian con lai

            soNamConLaiTruocKhiVeHuu = soNgayConLaiTruocKhiVeHuu / 365;             //So nam con lai truoc khi ve huu = phan nguyen cua so ngay con lai/365
            soThangConLaiTruocKhiVeHuu = (soNgayConLaiTruocKhiVeHuu % 365) / 30;    //So thang con lai truoc khi ve huu = phan du cua so ngay con lai%365 roi chia cho 30
            soNgayConLaiTruocKhiVeHuu = soNgayConLaiTruocKhiVeHuu % 365 % 30;       //So ngay con lai truoc khi ve huu = phan du cua  so ngay con lai%365%30

            //Xuat du lieu
            if (soNgayConLaiTruocKhiVeHuu > 0)
            {
                //Neu con lam viec, xuat so ngay con lai truoc khi ve huu
                Console.WriteLine("Thoi gian lam viec con lai truoc khi ve huu la: {0} nam {1} thang {2} ngay ", soNamConLaiTruocKhiVeHuu, soThangConLaiTruocKhiVeHuu, soNgayConLaiTruocKhiVeHuu);
            }
            else
            {
                //Neu da ve huu
                Console.WriteLine("Ban da ve huu roi.");
            }
        }

        static void ChuongTrinh_TinhKhoangCachGiuaDiemVaDuongThang()
        {
            // Khai bao 5 so thuc xM, yM, a, b, c
            double xM, yM, a, b, c;

            // Khai bao so thuc h
            double h;

            // Khai bao tu so, mau so
            double tuSo, mauSo;

            // Nhap lieu cho 5 so thuc xM, yM, a, b, c
            Console.Write("xM=");
            xM = double.Parse(Console.ReadLine());

            Console.Write("yM=");
            yM = double.Parse(Console.ReadLine());

            Console.Write("a=");
            a = double.Parse(Console.ReadLine());

            Console.Write("b=");
            b = double.Parse(Console.ReadLine());

            Console.Write("c=");
            c = double.Parse(Console.ReadLine());

            //tuSo = Tri tuyet doi(a*xM + b*yM + C)
            tuSo = Math.Abs(a * xM + b * yM + c);

            //mauSo = Can bac 2(a^2 + b^2)
            mauSo = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));

            // h = tuSo/mauSo
            h = tuSo / mauSo;

            // Ket xuat h
            Console.WriteLine("Khoang cach tu M toi duong thang la: {0}", h);
        }

        static void ChuongTrinh_TinhTuoiSuDungBienCauTruc()
        {
            // khai bao bien cau truc nhan vien
            NHANVIEN nhanVien = new NHANVIEN();

            // nhap lieu cho bien cau truc nhan vien
            nhanVien.hoTen = "Tran Van Tam Em";
            nhanVien.ngaySinh = new DateTime(1990, 2, 2);

            // tinh tuoi = nam hien hanh - nam sinh
            int namHienHanh = DateTime.Today.Year;
            nhanVien.tuoi = namHienHanh - nhanVien.ngaySinh.Year;

            // ngay ve huu = ngay sinh + 60 nam
            DateTime ngayVeHuu = nhanVien.ngaySinh.AddYears(60);

            // nam lam viec con lai = nam ve huu - nam hien hanh
            int namConLai = ngayVeHuu.Year - namHienHanh;

            // xuat thong tin nhan vien, ngay ve huu, thoi gian lam viec con lai
            Console.WriteLine("Ho ten: {0}", nhanVien.hoTen);
            Console.WriteLine("Ngay sinh: {0} ({1}), {2} tuoi",
                nhanVien.ngaySinh.ToString("dd/MM/yyyy"),
                nhanVien.ngaySinh.DayOfWeek,
                nhanVien.tuoi);
            Console.WriteLine("Ngay ve huu: {0} ({1})", ngayVeHuu.ToString("dd/MM/yyyy"), ngayVeHuu.DayOfWeek);
            Console.WriteLine("Thoi gian lam viec con lai: {0} nam", namConLai);

            Console.ReadKey();
        }

        static void ChuongTrinh_TinhTongCacChuSoCuaSoBatKi()
        {
            #region Tóm tắt yêu cầu
            // Nhap
            //     So nguyen n bat ki
            // Xuat
            //     Tong cac chu so cua so nguyen n
            // Qui tac xu ly
            //     Lay so ki tu cua so nguyen n
            //     Lay phan nguyen bang phep toan n / 10 luy thua (so ki tu - 1)
            //     Tong = Tong + phan nguyen;
            //     Lay phan du bang phep toan n % 10 luy thua (so ki tu - 1)
            //     n = phan du
            //     so ki tu = so ki tu - 1
            //     Lap lai xu ly cho den khi so ki tu bang 0 thi dung lai
            #endregion

            #region Lập trình
            int soBatki;        // Khai bao so nguyen soBatki
            int tongChuSo = 0;  // Khai bao so nguyen tongChuSo
            int soKiTu;         // Khai bao so nguyen cnt

            // Nhap lieu n la so nguyen bat ki
            Console.Write("Nhap n= ");
            soBatki = int.Parse(Console.ReadLine());

            // Xy ly chinh
            soKiTu = soBatki.ToString().Length;  // cnt so chu so cua n

            // neu cnt > 0 thi thuc hien xu ly tinh toan
            while (soKiTu > 0)
            {
                int phanNguyen = soBatki / (int)Math.Pow(10, soKiTu - 1);     // phan nguyen hien tai = soBatki/10^soKiTu-1
                tongChuSo = tongChuSo + phanNguyen;                         // tongChuSo = tongChuSo + phan nguyen hien tai
                int phanDu = soBatki % (int)Math.Pow(10, soKiTu - 1);         // phan du hien tai = soBatki%10^soKiTu-1
                soBatki = phanDu;                                           // soBatki = phan du hien tai
                soKiTu--;                                                   // giam cnt di 1 don vi
            }

            // Ket xuat tong
            Console.WriteLine("S= {0} ", tongChuSo);
            #endregion
        }

        static void ChuongTrinh_TinhGiamGiaCoDieuKien()
        {
            #region Tóm tắt yêu cầu
            //Nhap
            //     Ten mat hang
            //     So luong
            //     Don gia
            // Xuat
            //     Tong tien phai tra
            // Qui tac xu ly
            //     Neu mua so luong nho hon 50 = so luong * don gia
            //     Neu mua so luong tu 50 den 100 = so luong * don gia * 0.92
            //     Neu mua so luong tren 100 = so luong * don gia * 0.88
            //Khai bao kieu du lieu cau truc phieu mat hang
            #endregion

            #region Lập trình
            MATHANG matHang = new MATHANG();

            //Khai bao bien xu ly
            double tiLeGiam = 0;

            //Nhap lieu cho mat hang
            matHang.tenMatHang = "Sua tam con de";
            matHang.soLuong = 100;
            matHang.donGia = 10;

            //Xu ly chinh
            if (matHang.soLuong < 50)                                        //Neu mua so luong nho hon 50
            {
                tiLeGiam = 0;                                               //Khong duoc giam
            }
            else if (matHang.soLuong >= 50 || matHang.soLuong <= 100)       //Neu mua so luong tu 50 den 100
            {
                tiLeGiam = 0.08;                                            //Giam 8%
            }
            else if (matHang.soLuong > 100)                                 //Neu mua so luong tren 100
            {
                tiLeGiam = 0.12;                                            //Giam 12%
            }

            matHang.tongTien = matHang.soLuong * matHang.donGia;

            //Xuat tien
            Console.WriteLine("Ten mat hang : {0}", matHang.tenMatHang);
            Console.WriteLine("So luong     : {0}", matHang.soLuong.ToString("N"));
            Console.WriteLine("Don gia      : {0}", matHang.donGia.ToString("N"));
            Console.WriteLine("Tong tien    : {0}", matHang.tongTien.ToString("N"));
            Console.WriteLine("Giam gia     : {0}", (matHang.tongTien * tiLeGiam).ToString("N"));
            Console.WriteLine("Thanh tien   : {0}", (matHang.tongTien * (1 - tiLeGiam)).ToString("N"));
            Console.ReadKey();
            #endregion
        }

        static void ChuongTrinh_TinhTienTaxi()
        {
            #region Tóm tắt yêu cầu
            // Nhap
            //     Ho ten
            //     So km
            // Xuat
            //     Tien phai tra
            // Qui tac xu ly
            //     Neu nho hon hoac bang 1km
            //         Tien = 11000
            //     Neu lon hon 11km
            //         Tien = 11000 + (So km - 1)*9000
            #endregion

            #region Lập trình
            //Khai bao bien nhap chuoi ho ten
            string hoTen;
            //Khai bao bien nhap so thuc thuc so km
            double soKm;
            //Khai bao bien xuat so thuc so tien phai tra
            double tien;
            //Nhap lieu cho cac bien nhap
            hoTen = "Tran Van Tam Em";
            soKm = 11.4;

            //Xy ly chinh
            if (soKm <= 1)//Neu nho hon hoac bang 1km
            {
                //Tien = 11000
                tien = 11000;
            }
            else//Neu lon hon 11km
            {
                //Tien = 11000 + (So km - 1)*9000
                tien = 11000 + (soKm - 1) * 9000;
            }

            //Ket xuat
            Console.WriteLine("Ho ten           :{0}", hoTen);
            Console.WriteLine("So km da di      :{0}", soKm);
            Console.WriteLine("So tien phai tra :{0}", tien.ToString("N"));

            Console.ReadKey();
            #endregion
        }

        static void ChuongTrinh_TinhTienDien()
        {
            #region Tóm tắt yêu cầu
            // Nhap
            //     Ho ten
            //     So Kw dien da su dung
            // Xuat
            //     Tong tien
            // Qui tac xu ly
            //     50kw dau        -> gia 500
            //     50kw ke tiep    -> gia 650
            //     100kw ke tiep   -> gia 850
            //     150kw ke tiep   -> gia 1100
            //     Cac kw con lai  -> gia 1300
            #endregion

            #region Lập trình
            //Khai bao bien nhap chuoi ho ten
            string hoTen;
            //Khai bao bien nhap double so kw
            double kw;
            //Khai bao bien xuat tong tien
            double tongTien;

            //Nhap lieu bien nhap
            hoTen = "Tran Van Tam Em";
            kw = 60;

            //Xu ly chinh
            //     50kw dau        -> gia 500
            if (kw <= 50)
            {
                tongTien = kw * 500;
            }
            //     50kw ke tiep    -> gia 650
            else if (kw > 50 || kw <= 100)
            {
                tongTien = 50 * 500 + (kw - 50) * 650;
            }
            //     100kw ke tiep   -> gia 850
            else if (kw > 100 || kw <= 200)
            {
                tongTien = 50 * 500 + 50 * 650 + (kw - 100) * 850;
            }
            //     150kw ke tiep   -> gia 1100
            else if (kw > 200 || kw <= 350)
            {
                tongTien = 50 * 500 + 50 * 650 + 100 * 850 + (kw - 200) * 1100;
            }
            //     Cac kw con lai  -> gia 1300
            else
            {
                tongTien = 50 * 500 + 50 * 650 + 100 * 850 + 150 * 1100 + (kw - 350) * 1300;
            }

            //Ket xuat tong tien su dung
            Console.WriteLine("Ho ten           :{0}", hoTen);
            Console.WriteLine("So kw da xai     :{0}", kw);
            Console.WriteLine("So tien phai tra :{0}", tongTien.ToString("N"));
            Console.ReadKey();
            #endregion

        }

        static void ChuongTrinh_TinhTienBanHangCoDieuKien()
        {
            #region Tóm tắt yêu cầu
            /*
             * Nhập
             *      Thông tin mặt hàng (Tên, Loại, Số Lượng, Đơn giá)
             *      
             * Xuất
             *      Tổng tiền phải trả
             *      
             * Qui tắc xử lý
             *      Loại mặt hàng = A
             *          Tiền trả = Số lượng * Đơn giá * 0.9
             *      Loại mặt hàng != A
             *          Số lượng <= 100
             *              Tiền trả = Số lượng * Đơn giá * 0.9
             *          Số lượng > 100
             *              Tiền trả = Số lượng * Đơn giá * 0.92
             */
            #endregion

            #region Thuật giải
            /*
             * Khai báo biến
             *      Biến cấu trúc mặt hàng (Tên, Loại, Số Lượng, Đơn giá)
             *      Biến double tổng tiền phải trả
             *      
             * Nhập liệu 
             *      Nhập liệu cho danh sách mặt hàng
             * 
             * Xử lý chính
             *      Duyệt danh sách mặt hàng
             *          Nếu mặt hàng = A
             *              Tỉ lệ giảm = 0.1
             *          Nếu mặt hàng là (B hoặc C) và số lượng <= 100
             *              Tỉ lệ giảm = 0
             *          Nếu mặt hàng là (B hoặc C) và số lượng > 100
             *              Tỉ lệ giảm = 0.8
             *              
             *          Tiền trả = Số lượng * Đơn giá * (1-Tỉ lệ giảm)
             *          Tổng tiền = Tổng tiền + tiền trả
             * 
             * Kết xuất
             *      Tổng tiền phải trả
             */
            #endregion

            #region Lập trình

            //Khai báo biến

            //Biến cấu trúc mặt hàng(Tên, Loại, Số Lượng, Đơn giá)            
            MATHANG[] dsMatHang = new MATHANG[3];
            dsMatHang[0].tenMatHang = "A1";
            dsMatHang[0].loaiMatHang = "A";
            dsMatHang[0].soLuong = 10;
            dsMatHang[0].donGia = 1200;

            dsMatHang[1].tenMatHang = "B1";
            dsMatHang[1].loaiMatHang = "B";
            dsMatHang[1].soLuong = 100;
            dsMatHang[1].donGia = 1000;

            dsMatHang[2].tenMatHang = "C1";
            dsMatHang[2].loaiMatHang = "C";
            dsMatHang[2].soLuong = 101;
            dsMatHang[2].donGia = 1000;

            //Biến double tổng tiền phải trả
            double tongTien = 0;

            //Xử lý chính
            for(int i=0; i<dsMatHang.Length; i++)
            {
                MATHANG matHang = dsMatHang[i];
                double tiLeGiam = 0;

                //Nếu mặt hàng = A
                if ("A".Equals(matHang.loaiMatHang))
                {
                    tiLeGiam = 0.1;         //Tỉ lệ giảm = 0.1
                }
                //Nếu mặt hàng là (B hoặc C) và số lượng <= 100
                else if (("B".Equals(matHang.loaiMatHang) || "C".Equals(matHang.loaiMatHang)) && matHang.soLuong <= 100)
                {                    
                    tiLeGiam = 0;           //Tỉ lệ giảm = 0
                }
                //Nếu mặt hàng là (B hoặc C) và số lượng > 100
                else if (("B".Equals(matHang.loaiMatHang) || "C".Equals(matHang.loaiMatHang)) && matHang.soLuong > 100)
                {                    
                    tiLeGiam = 0.08;        //Tỉ lệ giảm = 0.08
                }

                matHang.tongTien = TinhToan_TinhTienMatHang(matHang.soLuong, matHang.donGia, tiLeGiam);
                tongTien += matHang.tongTien;
                
                Console.WriteLine("Ten mat hang : {0}", matHang.tenMatHang);
                Console.WriteLine("Loai mat hang: {0}", matHang.loaiMatHang);
                Console.WriteLine("So luong     : {0}", matHang.soLuong);
                Console.WriteLine("Don gia      : {0}", matHang.donGia.ToString("N"));
                Console.WriteLine("Tong tien    : {0}", (matHang.soLuong*matHang.donGia).ToString("N"));
                Console.WriteLine("Tien giam    : {0}", (matHang.soLuong*matHang.donGia*tiLeGiam).ToString("N"));
                Console.WriteLine("Thanh tien   : {0}", matHang.tongTien.ToString("N"));
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("Tong tien phai tra: {0}", tongTien.ToString("N"));

            #endregion
        }

        static void ChuongTrinh_XuLyMang()
        {
            // Cach 1: khai bao ma ko cap vung nho
            int[] a;
            a = new int[3];

            // Cach 2: khai bao va cap phat vung nho
            int[] b = new int[4];

            // Cach 3: khai bao, cap phat vung nho, gan du lieu ban dau
            int[] c = new int[] { 9, 2, -5 };

            int kichThuocMang;

            Console.Write("Nhap so phan tu cua mang d = ");
            kichThuocMang = int.Parse(Console.ReadLine());

            int[] d = new int[kichThuocMang];

            for(int i =0; i<d.Length; i++)
            {
                Console.Write("d["+i+"]=");
                d[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dach sang mang vua nhap: ");
            foreach (int item in d)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        static void ChuongTrinh_TinhKetQuaHocTap()
        {
            //Khai bao mang hoc sinh
            HOCSINH[] dsHocSinh;
            int siSoLopHoc;

            //Nhap so luong hoc sinh cua lop hoc
            Console.Write("Nhap si so lop: ");
            siSoLopHoc = int.Parse(Console.ReadLine());
            dsHocSinh = new HOCSINH[siSoLopHoc];

            //Nhap lieu cho mang hoc sinh
            for (int i = 0; i < dsHocSinh.Length; i++)
            {
                //Khai bao bien tam tien cho viec xu ly
                var hocSinh = dsHocSinh[i];

                //Thong tin thong bao
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Nhap thong tin hoc sinh thu {0}", i+1);

                //Nhap thong tin chi tiet
                Console.Write("Ho Ten: ");
                hocSinh.hoTen = Console.ReadLine();
                Console.Write("Diem Toan: ");
                hocSinh.diemToan = double.Parse(Console.ReadLine());
                Console.Write("Diem Van: ");
                hocSinh.diemVan = double.Parse(Console.ReadLine());
                Console.Write("Diem Anh: ");
                hocSinh.diemAnh = double.Parse(Console.ReadLine());

                //Tinh diem trung binh moi hoc sinh
                hocSinh.diemTB = TinhToan_DiemTrungBinh(hocSinh.diemToan, hocSinh.diemVan, hocSinh.diemAnh);

                //Gan nguoc bien tam vao lai mang chinh
                dsHocSinh[i] = hocSinh;
            }

            //Lay danh sach hoc sinh tren trung binh
            HOCSINH[] dsTrenTB = dsHocSinh.Where(x => x.diemTB >= 5).ToArray();           

            //Tim hoc sinh gioi nhat
            HOCSINH hsGioiNhat = TinhToan_TimHocSinhGioiNhat(dsHocSinh);

            //Tim hoc sinh yeu nhat
            HOCSINH hsYeuNhat = TinhToan_TimHocSinhYeuNhat(dsHocSinh);

            //Xuat danh sanh hoc sinh tren trung binh
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Danh sanh hoc sinh tren trung binh");
            for (int i = 0; i < dsTrenTB.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, dsTrenTB[i].hoTen);
            }

            //Xuat hoc sinh gioi nhat
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Hoc sinh gioi nhat");
            Console.WriteLine("Ho ten  {0}", hsGioiNhat.hoTen);
            Console.WriteLine("Diem TB {0}", hsGioiNhat.diemTB);

            //Xuat hoc sinh yeu nhat
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Hoc sinh yeu nhat");
            Console.WriteLine("Ho ten  {0}", hsYeuNhat.hoTen);
            Console.WriteLine("Diem TB {0}", hsYeuNhat.diemTB);
        }

        static void ChuongTrinh_XuLyMang_Nhom_1()
        {
            // Nhom 1: Ket qua xu ly la mot con so
            int[] a = new int[] { 1,3,4,7,-9,-1,12,-14,45,108};
            int kichThuoc = a.Length;
            int tong = a.Sum();
            double trungBinh = a.Average();
            int soLonNhat = a.Max();
            int soNhoNhat = a.Min();
            int soLuognAm = a.Count(x=> x<0);
            int tongPhanTuBeHonNam = a.Where(x => x < 5 && x > 0).Sum();

            Console.ReadLine();
        }

        static void ChuongTrinh_XuLyMang_Nhom_2()
        {
            // Nhom 2: Ket qua xu ly la mot mang con
            int[] a = new int[] { 1, 3, 4, 7, -9, -1, 12, -14, 45, 108 };
            
            //b = Lay mang cac so duong cua a
            int[] b = a.Where(x => x > 0).ToArray();

            //b1 = Lay mang cac so chan
            int[] b1 = a.Where(x => x % 2 == 0).ToArray();

            //c = Mang cua a sau khi xep tang
            int[] c = a.OrderBy(x => x).ToArray();

            //c1 = Lay mang cac so le tang dan
            int[] c1 = a.Where(x => x % 2 != 0).OrderBy(y => y).ToArray();

            //d = Mang cua a sau khi xep giam
            int[] d = a.OrderBy(x => -x).ToArray();

            //d = Mang cua a sau khi sap thu tu theo binh phuong
            int[] e = a.OrderBy(x => x * x).ToArray();

            Console.ReadLine();
        }

        static void ChuongTrinh_XuLyMang_Nhom_3()
        {
            // Nhom 2: Ket qua xu ly la mot gia tri logic true/false
            int[] a = new int[] { 1, 3, 4, 7, -9, -1, 12, -14, 45, 108 };
            string[] x = new string[] { "Hung", "Minh", "Long", "Nga" };

            //f = a co chua so nguyen 12
            bool f = a.Contains(12);

            //g = x co chua chuoi "Minh"
            bool g = x.Contains("Minh");

            Console.ReadLine();
        }

        static void ChuongTrinh_XuLyMang_Nhom_4()
        {
            // Nhom 4: ket qua tra ve la mot phan tu trong mang
            int[] a = new int[] { 1, 3, 4, 7, -9, -1, 12, -14, 45, 108 };

            //b = Phan tu so duong dau tien
            int b =  a.First(x=> x > 0);

            //c = phan tu so am cuoi cung
            int c = a.Last(x => x < 0);

            //d = phan tu am nho nhat
            int d = a.Where(x => x < 0).Min();

            Console.ReadLine();
        }

        static void ChuongTrinh_TimThu6Ngay13()
        {
            #region Tóm tắt yêu cầu
            //Nhap vao mot nam nm
            //Duyet tu vong th lap tu 1 den 12
            //Ngay = ngay 13 thang th nam nm
            //Neu ngay la thu 6 -> thoat vong lap
            #endregion

            #region Thuật giải
            //Khai bao bien int nm
            //Khai bao bien ngay kq

            //Duyet tu vong th lap tu 1 den 12 va dieu kien kq == ngay 1/1/1
            //Ngay = ngay 13 thang th nam nm
            //Neu ngay la thu 6 -> gan kq = ngay vua tim thay -> thoat vong lap
            #endregion

            #region Lập trình
            //Khai bao bien int nm
            int nam;

            //Nhap lieu cho nam
            Console.Write("Nhap nam can tim thu 6 ngay 13: ");
            nam = int.Parse(Console.ReadLine());

            //Khai bao bien ngay kq
            DateTime kq = new DateTime();

            //Duyet tu vong th lap tu 1 den 12 va dieu kien kq == ngay 1/1/1
            for (int i = 1; i <= 12; i++)
            {
                //friDay13 = ngay 13 thang th nam nm
                DateTime friDay13 = new DateTime(nam, i, 13);
                if (friDay13.DayOfWeek == DayOfWeek.Friday)
                {
                    //Neu ngay la thu 6 -> gan kq = ngay vua tim thay -> thoat vong lap
                    kq = friDay13;
                    Console.WriteLine("Thu sau ngay 13 dau tien trong nam {0} la ngay: {1}", nam, kq.ToString("dd/MM/yyyy"));
                    break;
                }
                Console.WriteLine("Thang {0} khong co thu 6 ngay 13", i);
            }
            #endregion
        }

        static HOCSINH TinhToan_TimHocSinhGioiNhat(HOCSINH[] dsHocSinh)
        {
            HOCSINH hsGioiNhat = dsHocSinh[0];
            double diemTBCaoNhat = dsHocSinh[0].diemTB;
            foreach (HOCSINH hs in dsHocSinh)
            {
                if (hs.diemTB > diemTBCaoNhat)
                {
                    diemTBCaoNhat = hs.diemTB;
                    hsGioiNhat = hs;
                }
            }
            return hsGioiNhat;
        }

        static HOCSINH TinhToan_TimHocSinhYeuNhat(HOCSINH[] dsHocSinh)
        {
            HOCSINH hsYeuNhat = dsHocSinh[0];
            double diemTBThapNhat = dsHocSinh[0].diemTB;
            foreach (HOCSINH hs in dsHocSinh)
            {
                if (hs.diemTB < diemTBThapNhat)
                {
                    diemTBThapNhat = hs.diemTB;
                    hsYeuNhat = hs;
                }
            }
            return hsYeuNhat;
        }

        static double TinhToan_DiemTrungBinh(double diemToan, double diemVan, double diemAnh)
        {
            return (diemToan * 2 + diemVan * 2 + diemVan) / 5;
        }

        static double TinhToan_TinhTienMatHang(int soLuong, double donGia, double giamGia)
        {
            return soLuong * donGia * (1- giamGia);
        }


    }
}