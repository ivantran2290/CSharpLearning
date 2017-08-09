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
        static public int TinhTongChuSo(int n)
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
