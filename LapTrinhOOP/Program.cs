using System;
using LapTrinhOOP.HinhHoc;
using LapTrinhOOP.DaHinh;

namespace LapTrinhOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //LuyenTap_BienStatic();            

            //Khai bao bien kieu hoc Sinh
            //HocSinh hs;

            ////Xin cap phat vung nho
            //hs = new HocSinh();

            ////Nhap thong tin hoc sinh
            //hs.NhapThongTin();

            ////Nhap ket qua hoc tap
            //hs.NhapKetQuaHocTap();

            ////Xuat ket qua hoc tap
            //hs.XuatKetQuaHocTap();

            //Diem diemA;
            //diemA = new Diem();

            //diemA.NhapToaDo();
            //diemA.XuatToaDo();

            //Diem diemB;
            //diemB = new Diem(0, 6);
            //diemB.Name = "B";
            //diemB.XuatToaDo();

            //Console.WriteLine("Khoang cach 2 diem la: {0}", diemA.KhoangCach(diemB));

            //diemA.DiChuyenToiGocToaDo();
            //diemA.XuatToaDo();

            //Console.WriteLine("Khoang cach 2 diem la: {0}", diemA.KhoangCach(diemB));

            Cat cat = new Cat();
            //cat.NhapThongTin();
            //cat.XuatThongTin();
            cat.Speak();
            cat.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Dog dog = new Dog();
            //dog.NhapThongTin();
            //dog.XuatThongTin();
            dog.Speak();
            cat.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Chicken chicken = new Chicken();
            //dog.NhapThongTin();
            //dog.XuatThongTin();
            chicken.Speak();
            chicken.Run();

            Console.WriteLine("So luong animal hien tai la {0} ", Animal.Count);

            Console.ReadLine();
        }

        //static void LuyenTap_BienStatic()
        //{
        //    Console.WriteLine("So luong meo ban dau: {0}", Cat.Count);
        //    Console.WriteLine("-------------------------------");
        //    Cat meoMacDinh = new Cat();
        //    Console.WriteLine("So luong meo hien tai: {0}", Cat.Count);
        //    Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoMacDinh.Name, meoMacDinh.Weight, meoMacDinh.Height);

        //    Console.WriteLine("-------------------------------");
        //    Cat meoDen = new Cat("Meo den", 16, 2);
        //    Console.WriteLine("So luong meo hien tai: {0}", Cat.Count);
        //    Console.WriteLine("Thong tin meo vua duoc tao: {0}, {1}, {2}", meoDen.Name, meoDen.Weight, meoDen.Height);

        //    Console.WriteLine(CommonUtil.LyThua(3, 2));
        //    Console.WriteLine(TiengNhatUtils.ThuTrongTuan(DateTime.Today));
        //}
    }
}