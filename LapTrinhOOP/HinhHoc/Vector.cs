using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.HinhHoc
{
    public class Vector : ToaDo
    {
        private string _name;
        public string Name { get => String.IsNullOrEmpty(_name) ? "V" : _name; set => _name = value; }

        public Vector() : base()
        {
        }
        public Vector(double x, double y) : base(x, y)
        {
        }
    }
}
