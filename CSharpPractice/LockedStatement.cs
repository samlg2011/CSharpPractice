using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class LockedStatement
    {
        static void Main()
        {
            TestLock test = new TestLock();
            lock(test)
            {
                test.PrintResult();
            }
        }
    }
    internal class TestLock
    {
        internal void PrintResult()
        {
            Console.WriteLine("This segment is not accessable from other thread if using lock statment.");
        }
    }
}
