using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ValueTypeVSRefType
    {
        public static void value(int num)
        {
            num++;
        }
        public static void reference(ref int num)
        {
            num++;
        }
        static void Main()
        {
            int num;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The value type:");
            Console.WriteLine("Old value is {0}", num);
            value(num);
            Console.WriteLine("New value is {0}", num);
            Console.WriteLine();
            Console.WriteLine("The reference type:");
            Console.WriteLine("Old value is {0}", num);
            reference(ref num);
            Console.WriteLine("New value is {0}", num);
        }
    }
}
