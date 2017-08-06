using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearningCore
{
    static public class CommonUtils
    {        
        static public long LyThua(int coSo, int soMu)
        {
            long ketQua = 1;
            for(int i=0; i<soMu; i++)
            {
                ketQua *= coSo;
            }
            return ketQua;
        }
        static public int TinhTuoi(DateTime dateTime)
        {
            return DateTime.Today.Year - dateTime.Year;
        }
    }
    static public class MyConsole
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
    public enum GioiTinh
    {
        Nam = 1,
        Nu = 0
    }
}
