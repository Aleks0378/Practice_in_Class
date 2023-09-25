using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bar b1 = new Bar();
            Bar b2 = b1 + 100;
            //Console.WriteLine(b2);
            try
            {
                Console.WriteLine(b2[2]);
                Console.WriteLine("enter Value: ");
                int value = Convert.ToInt32(Console.ReadLine());
                b2[2] = value;
                Console.WriteLine(b2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
