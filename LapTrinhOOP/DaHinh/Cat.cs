using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    public class Cat :Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meo meo...");
        }
        public override void Run()
        {
            Console.WriteLine("Chay 4 chan");
        }
    }
}
