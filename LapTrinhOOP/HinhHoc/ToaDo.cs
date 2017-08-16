using CSharpLearningCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class ToaDo
    {
        protected double _x;
        protected double _y;

        public double Y { get => _y; set => _y = value; }
        public double X { get => _x; set => _x = value; }

        public ToaDo()
        {
        }
        public ToaDo(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public void NhapToaDo()
        {
            Console.WriteLine("------Nhap toa do diem------");

            this._x = ConsoleUtils.NhapSoThuc("x= ");
            this._y = ConsoleUtils.NhapSoThuc("y= ");
        }
        public void XuatToaDo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("({1}, {2})", this.X, this.Y);
        }
        public static ToaDo operator +(ToaDo d1, ToaDo d2)
        {
            ToaDo kq = new ToaDo();
            kq.X = d1.X + d2.X;
            kq.Y = d1.Y + d2.Y;
            return kq;
        }
        public static ToaDo operator -(ToaDo d1, ToaDo d2)
        {
            ToaDo kq = new ToaDo();
            kq.X = d1.X - d2.X;
            kq.Y = d1.Y - d2.Y;
            return kq;
        }        
    }
}
