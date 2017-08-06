using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.BatDau
{
    class Cat
    {
        private string _name;
        private double _weight;
        private double _height;

        public string Name { get => _name; set => _name = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public double Height { get => _height; set => _height = value; }        

        public static int Count = 0;

        public Cat()
        {
            Name = "Meo mac dinh";
            _weight = 20;
            _height = 5;
            Count++;
        }
        public Cat(string n, double w, double h)
        {
            Name = n;
            _weight = w;
            _height = h;
            Count++;
        }
    }
}
