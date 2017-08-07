using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.Interfaces
{
    public interface IDoAn
    {
        String getName();
        void An();
        double tinhTien();
        void gioMoCua();
    }

    public interface IMiMuoc
    {
        string getName();
        int thoiGianTrunMi();
    }

    public class Ramen : IDoAn, IMiMuoc
    {
        public string getName()
        {
            return "ラーメン";
        }
        public void An()
        {
            Console.WriteLine(this.getName() + "をたべた。");
        }
        public double tinhTien()
        {
            return 900;
        }
        public void gioMoCua()
        {
            Console.WriteLine("Mo cua buoi sang");
        }
        public void diMuaMi()
        {
            Console.WriteLine("Tao di mua mi, thang Sushi dau can mi");
        }
        public int thoiGianTrunMi()
        {
            return 2;
        }
    }

    public class Sushi : IDoAn
    {
        public string getName()
        {
            return "お寿司";
        }
        public void An()
        {
            Console.WriteLine(this.getName() + "をたべた。");
        }
        public double tinhTien()
        {
            return 1200;
        }
        public void gioMoCua()
        {
            Console.WriteLine("Mo cua buoi toi");
        }
        public void diMuaCa()
        {
            Console.WriteLine("OK, tao di mua ca. Thang ramen dau can ca");
        }
    }

    public class Soba : IMiMuoc, IDoAn
    {
        public void An()
        {
            Console.WriteLine(this.getName() + "をたべた。");
        }
        public string getName()
        {
            return "そーば";
        }
        public void gioMoCua()
        {
            throw new NotImplementedException();
        }
        public int thoiGianTrunMi()
        {
            return 5;
        }
        public double tinhTien()
        {
            throw new NotImplementedException();
        }
    }
}
