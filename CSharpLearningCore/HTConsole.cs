using System;
using System.Collections.Generic;
using System.Text;

namespace HuongThaoCore
{
    public static class HTConnsole
    {
        public static double NhapSoThuc(string ghiChu)
        {
            double kq;
            Console.Write(ghiChu);
            kq = double.Parse(Console.ReadLine());
            return kq;
        }
        public static int NhapSoNguyen(string ghiChu)
        {
            int kq;
            Console.Write(ghiChu);
            kq = int.Parse(Console.ReadLine());
            return kq;
        }

        public static int NhapSoNguyen(string ghiChu, params object[] args)
        {
            int kq;
            Console.Write(ghiChu, args);
            kq = int.Parse(Console.ReadLine());
            return kq;
        }
        
        public static string NhapChuoi(string ghiChu)
        {
            string kq;
            Console.Write(ghiChu);
            kq = Console.ReadLine();
            return kq;
        }
        public static DateTime NhapNgay(string ghiChu)
        {
            DateTime kq;
            Console.Write(ghiChu);
            kq = DateTime.Parse(Console.ReadLine());
            return kq;
        }
    }
}
