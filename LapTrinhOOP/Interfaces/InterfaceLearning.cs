using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.Interfaces
{
    public interface IDoAn
    {
        string Name { get; set; }
        void An();
        double tinhTien();
        void gioMoCua();
    }

    public interface IMiMuoc
    {
        string getName();
        int thoiGianTrunMi();
    }

    public interface Shape
    {
        void Draw();
        void Area();
    }

    public class Ramen : IDoAn, IMiMuoc
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

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
        private string _name;
        public string Name { get => _name; set => _name = value; }

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
        private string _name;
        public string Name { get => _name; set => _name = value; }

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

    public class Rectangle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh chu nhat");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    public class Square : Shape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh vuong");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Square  ");
        }
    }

    public class Circle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh chu tron");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle ");
        }
    }

    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            switch (shapeType)
            {
                case null:
                    return null;
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                case "CIRCLE":
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
