using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Gau gau...");
        }
        public override void Run()
        {
            Console.WriteLine("Chay 4 chan");
        }
    }
}
