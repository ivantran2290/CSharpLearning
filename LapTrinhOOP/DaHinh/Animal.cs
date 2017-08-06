using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    abstract class Animal
    {
        private string _name;
        private string _height;
        private string _weight;
        private static int _count;

        public Animal()
        {
            _count++;
        }

        public string Height { get => _height; set => _height = value; }
        public string Weight { get => _weight; set => _weight = value; }
        public string Name { get => _name; set => _name = value; }
        public static int Count { get => _count; }

        public abstract void Speak();
        public abstract void Run();
        public void NhapThongTin()
        {
            Console.WriteLine("------Nhap thong tin------");

            Console.Write("Ten= ");
            _name = Console.ReadLine();

            Console.Write("Chieu cao= ");
            _height = Console.ReadLine();

            Console.Write("Can nang= ");
            _weight = Console.ReadLine();
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
