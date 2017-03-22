using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Object Created. Press enter to destory.");
            Console.ReadLine();
            
        }
        ~Program()
        {
            Console.WriteLine("Object destroying.");
            Console.WriteLine("*************************");
            Console.WriteLine("The Destructor call will automatically invokes Finalize Method.\nThe programmer has no control when destructor will be executed because it is defined by garbage collector.\nWhen garbage collector found such objects, it removes them automatically and dree up memory.");
            Console.WriteLine("*************************");
        }
    }

    class Destructor
    {
        static void Main()
        {
            Program p = new Program();
        }
    }
}
