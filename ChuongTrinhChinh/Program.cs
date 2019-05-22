using System;
using LapTrinhOOP.Interfaces;
using LapTrinhOOP.DaHinh;
using LapTrinhOOP.HinhHoc;
using LapTrinhOOP.BatDau;
using HuongThaoCore;
using LapTrinhHam;

namespace ChuongTrinhChinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //LuyenTap_DaHinh();
            //ChuongTrinh.ChuongTrinh_TinhTuoiNhanVien();
            LuyenTap_Interface();
        }

        public static void LuyenTap_Interface()
        {
            Ramen ramen = new Ramen();
            ramen.gioMoCua();
            ramen.diMuaMi();
            Console.WriteLine("Thoi gian trung {0} la {1} phut", ramen.Name, ramen.ThoiGianTrungMi);
            ramen.An();
            ramen.tinhTien();
            Console.WriteLine();

            Sushi suShi = new Sushi();
            suShi.gioMoCua();
            suShi.diMuaCa();
            suShi.An();
            suShi.tinhTien();
            Console.WriteLine();

            Soba soba = new Soba();
            soba.gioMoCua();
            soba.diMuaMi();
            Console.WriteLine("Thoi gian trung {0} la {1} phut", soba.Name, soba.ThoiGianTrungMi);
            soba.An();
            soba.tinhTien();
            Console.WriteLine();
        }
        public static void LuyenTap_InterfaceFactoreDP()
        {
            //ShapeFactory shapeFacotry = new ShapeFactory();
            //IShape shape1 = shapeFacotry.getShape("CIRCLE");
            //shape1.Draw();
            //shape1.Area();
            //IShape shape2 = shapeFacotry.getShape("RECTANGLE");
            //shape2.Draw();
            //shape2.Area();
            //IShape shape3 = shapeFacotry.getShape("SQUARE");
            //shape3.Draw();
            //shape3.Area();

            //ShapeContainer shapeContainer;
            //shapeContainer = new ShapeContainer(new Rectangle());
            //shapeContainer.Area();
            //shapeContainer = new ShapeContainer(new Square());
            //shapeContainer.Area();
            //shapeContainer = new ShapeContainer(new Circle());
            //shapeContainer.Area();

            //Với mỗi Interface, ta define một Module tương ứng
            //DIContainer.SetModule<IDatabase, Database>();
            //DIContainer.SetModule<ILogger, Logger>();
            //DIContainer.SetModule<IEmailSender, SMSSender>();

            //DIContainer.SetModule<Cart, Cart>();

            //DI Container sẽ tự inject Database, Logger vào Cart
            var myCart = new Cart(new Database(), new Logger(), new SMSSender());
            myCart.Checkout(1, 2);

            //DIContainer.SetModule<IDatabase, Database>();
            //DIContainer.SetModule<ILogger, Logger>();
            //DIContainer.SetModule<IEmailSender, EmailSender>();

            //DIContainer.SetModule<User, User>();
            var myUser = new User(new Database(), new EmailSender());
            myUser.Register();

            //Console.WriteLine("Non Dependencies Injection");
            //NormalClient normalClient = new NormalClient();
            //normalClient.Serve1("s1");
            //normalClient.Serve2("s2");
            //normalClient.Serve3("s3");

            //Console.WriteLine("Dependencies Constructor Injection");
            //ConstructorInjectionClient client = new ConstructorInjectionClient(new Service1());
            //client.Serve("s1");
            //client = new ConstructorInjectionClient(new Service2());
            //client.Serve("s2");
            //client = new ConstructorInjectionClient(new Service3());
            //client.Serve("s3");

            //Console.WriteLine("Dependencies Setter Injection");
            //SetterInjectionClient setterClient = new SetterInjectionClient();
            //setterClient.Service = new Service1();
            //setterClient.Serve("s1");
            //setterClient.Service = new Service2();
            //setterClient.Serve("s2");
            //setterClient.Service = new Service3();
            //setterClient.Serve("s3");

            //Console.WriteLine("Dependencies Method Injection");
            //MethodInjectionClient methodClient = new MethodInjectionClient();
            //methodClient.Serve(new Service1(), "s1");
            //methodClient.Serve(new Service2(), "s2");
            //methodClient.Serve(new Service2(), "s3");

            Console.ReadKey();
        }
        public static void LuyenTap_DaHinh()
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
        public static void LuyenTap_HinhHoc()
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
        public static void LuyenTap_BienStatic()
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
        public static void LuyenTap_KetQuaHocTap()
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