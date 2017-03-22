using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class SealedClass
    {
        static void Main()
        {
            SealedOne seal = new SealedOne();
            seal.message();
        }
    }

    public sealed class SealedOne
    {
        public void message()
        {
            Console.WriteLine("A Sealed class cannot be a base class and it prevents derivation.");
        }
    }

    /*
    public class SealChild : SealedOne
    {
        message();
    }
    */
}
