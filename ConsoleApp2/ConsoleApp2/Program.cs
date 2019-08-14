using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int w = 6;
            int s;
/*            if (w < 0)
            {
                s = -1;

            }
            else
            {
                s = w * 2;
            }
            */
            //簡寫法:只有兩個條件 IF-ELSE 才能使用，超過兩個條件則不能使用簡寫法

            s = (w < 0) ? -1 : w * 2;

            Console.WriteLine("S="+ s );
            Console.ReadKey();

        }
    }
}
