using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    public class Cat :Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meo keu: meo meo...");
        }
        public override void Run()
        {
            Console.WriteLine("Meo chay: 4 chan");
        }
        public override void An()
        {
            Console.WriteLine("Meo an: ca");
        }
    }
}
