using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class CheckedStatment
    {
        static void Main()
        {
            int num = int.MaxValue;
            try
            {
                checked
                {
                    num++;
                    Console.WriteLine(num);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
