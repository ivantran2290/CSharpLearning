using System;
using LapTrinhOOP.Interfaces;
using LapTrinhOOP.DaHinh;
using LapTrinhOOP.HinhHoc;
using LapTrinhOOP.BatDau;
using CSharpLearningCore;

namespace ChuongTrinhChinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            LuyenTap_HinhHoc();
        }

        static public void LuyenTap_Interface()
        {
            Ramen ramen = new Ramen();
            ramen.gioMoCua();
            ramen.An();
            ramen.diMuaMi();
            Console.WriteLine("Thoi gian trung {0} la {1} phut", ramen.getName(), ramen.thoiGianTrunMi());
            Console.WriteLine("Thanh tien:  " + ramen.tinhTien().ToString("N"));
            Console.WriteLine();

            Sushi suShi = new Sushi();
            suShi.gioMoCua();
            suShi.An();
            suShi.diMuaCa();
            Console.WriteLine("Thanh tien:  " + suShi.tinhTien().ToString("N"));
            Console.WriteLine();

            Soba soba = new Soba();
            soba.An();
            Console.WriteLine("Thoi gian trung {0} la {1} phut", soba.getName(), soba.thoiGianTrunMi());
        }
        static public void LuyenTap_InterfaceFactoreDP()
        {
            ShapeFactory shapeFacotry = new ShapeFactory();
            Shape shape1 = shapeFacotry.getShape("CIRCLE");
            shape1.Draw();
            shape1.Area();
            Shape shape2 = shapeFacotry.getShape("RECTANGLE");
            shape2.Draw();
            shape2.Area();
            Shape shape3 = shapeFacotry.getShape("SQUARE");
            shape3.Draw();
            shape3.Area();
        }
        static public void LuyenTap_DaHinh()
        {
            Animal cat = new Cat();
            cat.NhapThongTin("Nhap thong tin cho Meo:");
            cat.XuatThongTin();
            cat.Speak();
            cat.Run();
            cat.An();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Animal dog = new Dog();
            dog.NhapThongTin("Nhap thong tin cho Cho:");
            dog.XuatThongTin();
            dog.Speak();
            dog.Run();
            dog.An();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Animal chicken = new Chicken();
            chicken.NhapThongTin("Nhap thong tin cho Ga:");
            chicken.XuatThongTin();
            chicken.Speak();
            chicken.Run();
            chicken.An();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);
        }
        static public void LuyenTap_HinhHoc()
        {
            Diem diemA = new Diem();
            diemA.NhapToaDo();
            Diem diemB = new Diem();
            diemB.NhapToaDo();
            Diem diemC = new Diem(2, 1);
            Diem diemD = new Diem(2, -1);

            DoanThang ab = new DoanThang(diemA, diemB);
            Console.WriteLine("V({0},{1})", ab.VTPT.X, ab.VTPT.Y);
            Console.WriteLine("U({0},{1})", ab.VTCP.X, ab.VTCP.Y);
            Console.WriteLine(ab.PTTongQuat);
            Console.WriteLine(ab.TimDuongTrungTruc().PTTongQuat);

            //DuongThang dt = new DuongThang(diemA, diemB);
            //diemA = new Diem();
            //diemA.NhapToaDo();

            //diemB = new Diem();
            //diemB.NhapToaDo();

            //DuongThang dtChuan = new DuongThang(diemA, diemB);
            //Console.WriteLine("Goc giua 2 duong thang la: {0}", dtChuan.GocVoiDuongThang(dt));

            //Console.WriteLine("PT tong quat co dang {0}", dt.PtTongQuat);
            //Console.WriteLine("He so goc: {0}", dt.HeSoGoc);
            //Console.WriteLine("Goc: {0}", dt.GocVoiOx);

            //Diem diemC;
            //diemC = new Diem();
            ////diemC.NhapToaDo();
            //////Console.WriteLine("Diem {0} {1} nam tren duong thang {2}{3}"
            //////    , diemC.Name, dt.ChuaDiem(diemC) ? "co": "khong", diemA.Name, diemB.Name);

            //TamGiac tg = new TamGiac(diemA, diemB, diemC);
            //double ab = new DuongThang(diemA, diemB).ChieuDai;
            //double bc = new DuongThang(diemB, diemC).ChieuDai;
            //double ca = new DuongThang(diemC, diemA).ChieuDai;

            //Console.WriteLine("Chieu dai doan thang {0} : {1}", "AB", ab);
            //Console.WriteLine("Chieu dai doan thang {0} : {1}", "BC", bc);
            //Console.WriteLine("Chieu dai doan thang {0} : {1}", "CA", ca);
            //Console.WriteLine("Dien tich tam giac la    : {0}", tg.DienTich);
            //Console.WriteLine("Chu vi tam giac la       : {0}", tg.ChuVi);

        }
        static public void LuyenTap_BienStatic()
        {
            //Console.WriteLine("So luong meo ban dau: {0}", BatDau.Cat.Count);
            //Console.WriteLine("-------------------------------");
            //BatDau.Cat meoMacDinh = new BatDau.Cat();
            //Console.WriteLine("So luong meo hien tai: {0}", BatDau.Cat.Count);
            //Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoMacDinh.Name, meoMacDinh.Weight, meoMacDinh.Height);

            //Console.WriteLine("-------------------------------");
            //BatDau.Cat meoDen = new BatDau.Cat("Meo den", 16, 2);
            //Console.WriteLine("So luong meo hien tai: {0}", BatDau.Cat.Count);
            //Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoDen.Name, meoDen.Weight, meoDen.Height);

            //Console.WriteLine(CommonUtils.LyThua(3, 2));
            //Console.WriteLine(TiengNhatUtils.ThuTrongTuan(DateTime.Today));
        }
        static public void LuyenTap_KetQuaHocTap()
        {
            //Khai bao bien kieu hoc Sinh
            HocSinh hs;

            //Xin cap phat vung nho
            hs = new HocSinh();

            //Nhap thong tin hoc sinh
            hs.NhapThongTin();

            //Nhap ket qua hoc tap
            hs.NhapKetQuaHocTap();

            //Xuat ket qua hoc tap
            hs.XuatKetQuaHocTap();
        }
    }
}