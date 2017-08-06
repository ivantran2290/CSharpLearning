using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    class Chicken:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chip chip...");
        }
        public override void Run()
        {
            Console.WriteLine("Chay 2 chan...");
        }
    }
}
