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
            int a, b,c,d;
            Console.WriteLine("Enter the values for A and B");
            a=int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            d = a - b;
            Console.WriteLine("{0},{1}",c,d);
        }
        
    }
}
