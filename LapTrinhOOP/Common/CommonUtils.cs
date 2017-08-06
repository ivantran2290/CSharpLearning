using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP
{
    static class CommonUtil
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
    enum GioiTinh
    {
        Nam = 1,
        Nu = 0
    }
}
