using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.HinhHoc
{
    public class Diem: ToaDo
    {
        private string _name;
        public string Name { get => String.IsNullOrEmpty(_name) ? "M" : _name; set => _name = value; }

        public Diem():base()
        {
        }
        public Diem(double x, double y):base(x,y)
        {
            
        }
        
        public void DiChuyenToiGocToaDo()
        {
            this._x = 0;
            this._y = 0;
        }        
        public bool LaTrungDiem(DoanThang dt)
        {
            return this == dt.TrungDiem;
        }
        public bool LaGocToaDo()
        {
            return this == new Diem(0, 0);
        }
        public double KhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(this._x - d._x, 2) + Math.Pow(this._y - d._y, 2));
        }
        public Diem LayTrungDiem(Diem d)
        {
            return new Diem(
                (this.X + d.X) / 2,
                (this.Y + d.Y) / 2
            );
        }
    }
}
