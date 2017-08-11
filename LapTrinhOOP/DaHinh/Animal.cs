using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearningCore;

namespace LapTrinhOOP.DaHinh
{
    public abstract class Animal // Chỉ có lớp abstract thì mới có thể chứa các thuộc tính hoặc phương thức abstract bên trong nó
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

        public abstract void Speak();       // Hàm abstract bắt buộc phải có override
        public abstract void Run();         // Hàm abstract bắt buộc phải có override
        public virtual void An()            // Hàm virtual có thể có hoặc ko có override
        {
            Console.WriteLine("Dong van: an co");
        }

        // Hàm bình thường không có phép override, chỉ đc kế thừa
        // Hàm này có xài thuộc tính của đối tượng hiện tại, nên không thể khai báo static được
        public void NhapThongTin(string ghiChu) 
        {
            Console.WriteLine(ghiChu);

            Name = ConsoleUtils.NhapChuoi("Ten= ");
            Height = ConsoleUtils.NhapSoThuc("Chieu cao= ");
            Weight = ConsoleUtils.NhapSoThuc("Can nang= ");
        }

        // Hàm bình thường không có phép override, chỉ đc kế thừa
        // Hàm này có xài thuộc tính của đối tượng hiện tại, nên không thể khai báo static được
        public void XuatThongTin()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Ten          :{0}", Name);
            Console.WriteLine("Chieu cao    :{0}", Height);
            Console.WriteLine("Can nang     :{0}", Weight);            
        }

        // Hàm này không có sử dụng thuộc tính hoặc phương thức của đối tượng hiện tại --> nên chúng ta có thể đặt static cho nó
        static public void ThongChaoMung()
        {
            Console.WriteLine("Chào mừng đến với thế giới động vật");
        }
    }
}
