﻿using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.HinhHoc
{
    class Diem
    {
        private string _name;
        private double _x;
        private double _y;

        public double Y { get => _y; set => _y = value; }
        public double X { get => _x; set => _x = value; }
        public string Name { get => String.IsNullOrEmpty(_name)? "M" :_name ; set => _name = value; }

        public Diem()
        {
        }

        public Diem(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public void NhapToaDo()
        {
            Console.WriteLine("------Nhap toa do diem------");

            _name = ConsoleUtils.NhapChuoi("Ten= ");
            _x = ConsoleUtils.NhapSoThuc("x= ");
            _y = ConsoleUtils.NhapSoThuc("y= ");
        }

        public void XuatToaDo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("{0}({1}, {2})", this.Name, this.X, this.Y);
        }        

        public void DiChuyenToiGocToaDo()
        {
            this._x = 0;
            this._y = 0;
        }

        public double KhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(this.X - d.X, 2) + Math.Pow(this.Y - d.Y, 2));
        }
    }
}
