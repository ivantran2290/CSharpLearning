using System;
using LapTrinhOOP.HinhHoc;
using LapTrinhOOP.DaHinh;
using LapTrinhOOP.Interfaces;
using CSharpLearningCore;
using LapTrinhOOP.BatDau;

namespace LapTrinhOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LuyenTap_Interface();
            Console.ReadLine();
        }    
        public static void LuyenTap_Interface()
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
        static public void LuyenTap_DaHinh()
        {
            Animal cat = new DaHinh.Cat();
            cat.NhapThongTin();
            cat.XuatThongTin();
            cat.Speak();
            cat.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Animal dog = new Dog();
            dog.NhapThongTin();
            dog.XuatThongTin();
            dog.Speak();
            cat.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Animal chicken = new Chicken();
            dog.NhapThongTin();
            dog.XuatThongTin();
            chicken.Speak();
            chicken.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);
        }
        static public void LuyenTap_HinhHoc()
        {
            Diem diemA;
            diemA = new Diem();

            diemA.NhapToaDo();
            diemA.XuatToaDo();

            Diem diemB;
            diemB = new Diem(0, 6);
            diemB.Name = "B";
            diemB.XuatToaDo();

            Console.WriteLine("Khoang cach 2 diem la: {0}", diemA.KhoangCach(diemB));

            diemA.DiChuyenToiGocToaDo();
            diemA.XuatToaDo();

            Console.WriteLine("Khoang cach 2 diem la: {0}", diemA.KhoangCach(diemB));
        }
        static public void LuyenTap_BienStatic()
        {
            Console.WriteLine("So luong meo ban dau: {0}", BatDau.Cat.Count);
            Console.WriteLine("-------------------------------");
            BatDau.Cat meoMacDinh = new BatDau.Cat();
            Console.WriteLine("So luong meo hien tai: {0}", BatDau.Cat.Count);
            Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoMacDinh.Name, meoMacDinh.Weight, meoMacDinh.Height);

            Console.WriteLine("-------------------------------");
            BatDau.Cat meoDen = new BatDau.Cat("Meo den", 16, 2);
            Console.WriteLine("So luong meo hien tai: {0}", BatDau.Cat.Count);
            Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoDen.Name, meoDen.Weight, meoDen.Height);

            Console.WriteLine(CommonUtils.LyThua(3, 2));
            Console.WriteLine(TiengNhatUtils.ThuTrongTuan(DateTime.Today));
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