using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Answer: 9
            // Why: It ignores everything after the dot.

            #endregion
            #region Q2
            // Fix: double d2 = n / 2.0;
            // Why: Adding .0 makes it calculate the half (2.5) correctly.
            #endregion
            #region Q3
            // Answer:
            //int age = int.Parse(Console.ReadLine());
            #endregion
            #region Q4

            // Answer: The program will crash (Error).
            // Why: Because "12a" has a letter and can't be a number.
            #endregion
            #region Q5
            // Answer:
            //if (int.TryParse(s, out int x))
            //    Console.WriteLine(x);
            //else
            //    Console.WriteLine("Invalid");
            #endregion
            #region Q6
            // Answer: 11
            // Why: It takes 10 and adds 1 to it.
            #endregion
            #region Q7
            // Answer: Error.
            // How to fix: long x = Convert.ToInt64(o);
            #endregion

            #region Q8
            // Fix:
            //long x = (o is int) ? (int)o : -1;
            #endregion
            #region Q9
            // Answer: Blank (Nothing)
            // Why: Because the name is empty (null)
            #endregion
            #region Q10
            // Answer: 0
            
            #endregion
        }
    }
}