﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c,d,e;
            c = a + b;
            d = a - b;
            e = a / b;
            Console.WriteLine("{0} {1} {2}",c,d,e);
            swithcase obj = new swithcase();
            obj.Switch();
            Console.ReadKey();
            
        }
    }
}
