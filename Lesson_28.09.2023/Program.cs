using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? n = null;
            n = 8;

            Console.WriteLine(n ?? 3);
            Console.ReadLine();


        }
    }
}
