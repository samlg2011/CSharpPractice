using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class BreakNContinue
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<20)
            {
                i++;
                if (i<6)
                {
                    continue;
                }
                
                if(i==10)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Break segment.");
                    break;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}
