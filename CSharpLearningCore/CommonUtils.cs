﻿using System;
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
    }    
    public enum GioiTinh
    {
        Nam = 1,
        Nu = 0
    }
}
