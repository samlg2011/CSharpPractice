using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class UsingStatement
    {
        static void Main()
        {
            using (check_using check = new check_using())
            {
                Console.WriteLine("Some progress here.");
            }
        }
    }

    class check_using:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("The using statement is mostly used when you need one or more resources in a segment. \nThe using statement obtains one or various resources, excutes them and then releases. \nIt is widely used in database connectivity.");
            Console.WriteLine("***********************");
        }
    }
}
