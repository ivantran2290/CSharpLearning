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
        static public double PhuongTrinhBacNhat(double a, double b)
        {
            return -b/a;
        }
        static public double[] PhuongTrinhBac2(double a, double b, double c)
        {            
            double[] nghiem = new double[0];

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta > 0)
            {
                nghiem = new double[2];
                nghiem[0] = (-b - Math.Sqrt(delta)) / 2 * a;
                nghiem[1] = (-b + Math.Sqrt(delta)) / 2 * a;
            }
            else if (delta == 0)
            {
                nghiem = new double[1];
                nghiem[0] = -b / 2 * a;
            }
            else if(delta < 0)
            {
                nghiem = new double[0];
            }
            return nghiem;
        }
    }    
    public struct NGHIEM
    {
        public double x1;
        public double x2;
    }
    public enum GioiTinh
    {
        Nam = 1,
        Nu = 0
    }
}
