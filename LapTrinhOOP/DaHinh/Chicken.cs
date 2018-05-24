﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhOOP.DaHinh
{
    public class Chicken :Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chip chip...");
        }
        public override void Run()
        {
            Console.WriteLine("Chay 2 chan...");
        }
        public override void An()
        {
            Console.WriteLine(this.Name + " an lua");
        }
    }
}
