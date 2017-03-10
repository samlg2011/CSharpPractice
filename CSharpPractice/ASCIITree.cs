using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ASCIITree
    {
        static void Main(string[] args)
        {
            //Handling user input and exceptions
            Console.WriteLine("Enter the number of lines of your tree(0-10):");
            int high = 0;
            int.TryParse(Console.ReadLine(), out high);
            try
            {
                if (high < 1 || high > 10)
                {
                    throw (new InvalidNumberException("You may wanna input a NUMBER greater than 0 and less then 10."));
                }else
                {
                    //Print out chrismas tree
                    for (int col = 1; col <= high; col++)
                    {
                        for (int row = 0; row < high - col; row++)
                        {
                            Console.Write(" ");
                        }
                        for (int row = 1; row <= col; row++)
                        {
                            Console.Write(row);
                        }
                        for (int row = col; row > 1; row--)
                        {
                            Console.Write(row - 1);
                        }
                        Console.WriteLine();
                    }
                    for (int row = 1; row <= high - 1; row++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            catch (InvalidNumberException oex)
            {
                Console.WriteLine(oex.Message.ToString());
            }
        }
    }

    //Custom exception for non integer input value or 0
    internal class InvalidNumberException : Exception
    {
        internal InvalidNumberException(string msg) : base(msg) { }
    }
}
