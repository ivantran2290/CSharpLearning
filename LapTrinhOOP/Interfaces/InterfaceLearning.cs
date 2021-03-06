﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LapTrinhOOP.Interfaces
{
    public interface IDoAn
    {
        string Name { get; set; }
        string getName();
        void An();
        double tinhTien();
        void gioMoCua();
    }

    public interface IMiMuoc
    {        
        int thoiGianTrunMi();
        void diMuaMi();
    }

    public interface ICaSong
    {
        void diMuaCa();
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
            Console.WriteLine("Di mua ve ve nau Ramen");
        }
        public int thoiGianTrunMi()
        {
            return 2;
        }
    }

    public class Soba : IDoAn, IMiMuoc
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public void An()
        {
            Console.WriteLine(this.getName() + "をたべた。");
        }
        public void diMuaMi()
        {
            Console.Write("Di mua mi ve nau Soba");
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

    public class Sushi : IDoAn, ICaSong
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
            Console.WriteLine("Di mua ca ve lam Sushi");
        }
    }

    public class ShaShimi : IDoAn, ICaSong
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public void An()
        {
            Console.WriteLine(this.getName() + "をたべた。");
        }
        public void diMuaCa()
        {
            Console.WriteLine("Mua ca ve lam Sashimi");
        }
        public string getName()
        {
            return "お刺身";
        }
        public void gioMoCua()
        {
            Console.WriteLine("Chi mo cua va cuoi tuan");
        }
        public double tinhTien()
        {
            return 100000;
        }
    }

    public interface IShape
    {
        void Draw();
        void Area();
    }

    public class Rectangle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh chu nhat");
        }

        public void Draw()
        {
            Console.WriteLine("Ve hinh chu nhat");
        }
    }

    public class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh vuong");
        }

        public void Draw()
        {
            Console.WriteLine("Ve hinh vuong");
        }
    }

    public class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Dien tich hinh chu tron");
        }

        public void Draw()
        {
            Console.WriteLine("Ve hinh tron");
        }
    }

    public class ShapeFactory
    {
        public IShape getShape(string shapeType)
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

    public class ShapeContainer
    {
        private IShape _shape;

        public ShapeContainer(IShape shape)
        {
            this._shape = shape;
        }

        public void Area()
        {
            this._shape.Area();
        }
        public void Draw(string note)
        {
            this._shape.Draw();
        }
    }
}

public interface IService
{
    void Serve(string note);
}

public class Service2 : IService
{
    public void Serve(string note)
    {
        Console.WriteLine("{0} Called", note);
    }
}

public class Service1 : IService
{
    public void Serve(string note)
    {
        Console.WriteLine("{0} Called", note);
    }
}

public class Service3 : IService
{
    public void Serve(string note)
    {
        Console.WriteLine("{0} Called", note);
    }
}

#region No Injection
public class NormalClient
{
    public Service1 s1 = new Service1();
    public Service2 s2 = new Service2();
    public Service3 s3 = new Service3();

    public NormalClient()
    {
    }

    public void Serve1(string note)
    {
        Console.WriteLine("Service of non-injection object started");
        s1.Serve("s1");
    }
    public void Serve2(string note)
    {
        Console.WriteLine("Service of non-injection object started");
        s2.Serve("s2");
    }
    public void Serve3(string note)
    {
        Console.WriteLine("Service of non-injection object started");
        s2.Serve("s3");
    }
}
#endregion
#region Constructor Injection 

public class ConstructorInjectionClient
{
    private IService _service;

    public ConstructorInjectionClient(IService service)
    {
        this._service = service;
    }

    public void Serve(string note)
    {
        Console.WriteLine("Service of constructor injection started");
        this._service.Serve(note);
    }
}
#endregion
#region Setter injection
public class SetterInjectionClient
{
    private IService _service;

    public IService Service
    {
        set
        {
            this._service = value;
        }
    }

    public void Serve(string note)
    {
        Console.WriteLine("Service of setter injection started");
        this._service.Serve(note);
    }
}
#endregion
#region Method injection
public class MethodInjectionClient
{
    private IService _service;

    public void Serve(IService service, string note)
    {
        this._service = service;
        Console.WriteLine("Service of method injection started");
        this._service.Serve(note);
    }
}
#endregion
// Interface
public interface IDatabase
{
    void SaveOrder(int orderId);
    void SaveUser(int userId);
}

public interface ILogger
{
    void LogInfo(string info);
}

public interface IEmailSender
{
    void SendCheckOUtEmail(int userId);
    void SendRegisterUserMail(int userId);
}

// Các Module implement các Interface
public class Logger : ILogger
{
    public void LogInfo(string info)
    {
        Console.WriteLine(info);
    }
}

public class Database : IDatabase
{
    public void SaveOrder(int orderId)
    {
        Console.WriteLine("Order number {0} is saved", orderId);
    }

    public void SaveUser(int userId)
    {
        Console.WriteLine("User number {0} is saved", userId);
    }
}

public class EmailSender : IEmailSender
{
    public void SendCheckOUtEmail(int userId)
    {
        Console.WriteLine("Email: User {0} is check out", userId);
    }

    public void SendRegisterUserMail(int userId)
    {
        Console.WriteLine("Email: New user {0} is registerd", userId);
    }
}

public class SMSSender : IEmailSender
{
    public void SendCheckOUtEmail(int userId)
    {
        Console.WriteLine("SMS: User {0} is check out", userId);
    }

    public void SendRegisterUserMail(int userId)
    {
        Console.WriteLine("Email: New user {0} is registerd", userId);
    }
}

public class Cart
{
    private readonly IDatabase _db;
    private readonly ILogger _log;
    private readonly IEmailSender _es;

    public Cart(IDatabase db, ILogger log, IEmailSender es)
    {
        _db = db;
        _log = log;
        _es = es;
    }

    public void Checkout(int orderId, int userId)
    {
        _db.SaveOrder(orderId);
        _log.LogInfo("Order has been checkout");
        _es.SendCheckOUtEmail(userId);
    }
}

public class User
{
    private readonly IDatabase _db;
    private readonly IEmailSender _es;
    private static int count;

    public User(IDatabase db, IEmailSender es)
    {
        _db = db;
        _es = es;
        count++;
    }

    public void Register()
    {
        _db.SaveUser(count);
        _es.SendRegisterUserMail(count);
    }
}


public class DIContainer
{
    //Dictionary để chứa các interface và module tương ứng
    private static readonly Dictionary<Type, object>
               ResgisteredModules = new Dictionary<Type, object>();

    //Hai hàm cơ bản, ở đây mình chuyển <T> thành 
    //dạng Type trong C# để dễ viết code
    public static void SetModule<TInterface, TModule>()
    {
        SetModule(typeof(TInterface), typeof(TModule));
    }

    public static T GetModule<T>()
    {
        return (T)GetModule(typeof(T));
    }

    private static void SetModule(Type interfaceType, Type moduleType)
    {
        //Kiểm tra module đã implement interface chưa
        if (!interfaceType.IsAssignableFrom(moduleType))
        {
            throw new Exception("Wrong Module type");
        }

        //Tìm constructor đầu tiên
        var firstConstructor = moduleType.GetConstructors()[0];
        object module = null;
        //Nếu như không có tham số
        if (!firstConstructor.GetParameters().Any())
        {
            //Khởi tạo module
            module = firstConstructor.Invoke(null); // new Database(), new Logger()
        }
        else
        {
            //Lấy các tham số của constructor
            var constructorParameters = firstConstructor.GetParameters(); //IDatebase, ILogger

            var moduleDependecies = new List<object>();
            foreach (var parameter in constructorParameters)
            {
                var dependency = GetModule(parameter.ParameterType); //Lấy module tương ứng từ DIContainer
                moduleDependecies.Add(dependency);
            }

            //Inject các dependency vào constructor của module
            module = firstConstructor.Invoke(moduleDependecies.ToArray());
        }
        //Lưu trữ interface và module tương ứng
        ResgisteredModules.Add(interfaceType, module);
    }

    private static object GetModule(Type interfaceType)
    {
        if (ResgisteredModules.ContainsKey(interfaceType))
        {
            return ResgisteredModules[interfaceType];
        }
        throw new Exception("Module not register");
    }
}