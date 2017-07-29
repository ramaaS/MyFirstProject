using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class swithcase
    {
        public void Switch()
        {
            int a, b,c,d,e,f;
            Console.WriteLine("Enter the values for A and B");
            a=int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            Console.WriteLine("ashok :{0},{1} {2} {3} : goud :",c,d,e,f);
        }
        
    }
}