using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.DaHinh
{
    abstract class Animal
    {
        private string _name;
        private double _height;
        private double _weight;
        private static int _count;

        public Animal()
        {
            _count++;
        }


        public string Name { get => _name; set => _name = value; }        
        public double Height { get => _height; set => _height = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public static int Count { get => _count; }

        public abstract void Speak();
        public abstract void Run();
        public void NhapThongTin()
        {
            Console.WriteLine("------Nhap thong tin------");

            _name = MyConsole.NhapChuoi("Ten= ");
            _height = MyConsole.NhapSoThuc("Chieu cao= ");
            _weight = MyConsole.NhapSoThuc("Can nang= ");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Ten          :{0}", Name);
            Console.WriteLine("Chieu cao    :{0}", Height);
            Console.WriteLine("Can nang     :{0}", Weight);            
        }
    }
}
