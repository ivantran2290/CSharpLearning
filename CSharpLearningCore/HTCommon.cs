using System;
using System.Collections.Generic;
using System.Text;

namespace HuongThaoCore
{
    public static class HTCommon
    {        
        public static int LyThua(int coSo, int soMu)
        {
            int ketQua = 1;
            for(int i=0; i<soMu; i++)
            {
                ketQua *= coSo;
            }
            return ketQua;
        }
        public static int TinhTuoi(DateTime dateTime)
        {
            return DateTime.Today.Year - dateTime.Year;
        }
        public static int TinhTongChuSo(int n)
        {
            int S = 0;
            while (n > 0)
            {
                int d = n % 10;
                S += d;
                n = n / 10;
            }
            return S;
        }
    }    
    public enum GioiTinh
    {
        Nam = 1,
        Nu = 0
    }
}
