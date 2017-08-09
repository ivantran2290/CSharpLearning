using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearningCore
{
    static public class ConsoleUtils
    {
        static public double NhapSoThuc(string ghiChu)
        {
            double kq;
            Console.Write(ghiChu);
            kq = double.Parse(Console.ReadLine());
            return kq;
        }
        static public int NhapSoNguyen(string ghiChu)
        {
            int kq;
            Console.Write(ghiChu);
            kq = int.Parse(Console.ReadLine());
            return kq;
        }

        static public int NhapSoNguyen(string ghiChu, params object[] args)
        {
            int kq;
            Console.Write(ghiChu, args);
            kq = int.Parse(Console.ReadLine());
            return kq;
        }
        
        static public string NhapChuoi(string ghiChu)
        {
            string kq;
            Console.Write(ghiChu);
            kq = Console.ReadLine();
            return kq;
        }
        static public DateTime NhapNgay(string ghiChu)
        {
            DateTime kq;
            Console.Write(ghiChu);
            kq = DateTime.Parse(Console.ReadLine());
            return kq;
        }
    }
}
