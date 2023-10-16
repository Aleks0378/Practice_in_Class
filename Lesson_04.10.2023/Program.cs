using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер памяти в управляемой куче: "+GC.GetTotalMemory(false)+" байт");
            Console.WriteLine($"Кол-во поколений: {GC.MaxGeneration+1}"); 
            
            Console.WriteLine("Размер памяти в управляемой куче: " + GC.GetTotalMemory(false) + " байт");
            Console.WriteLine("Наш объект в поколении: "+GC.GetGeneration(args[0]));
            const int SIZE = 1000;
            Club[] list = new Club[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                list[i] = new Club();
            }
            Console.WriteLine("Размер памяти в управляемой куче: " + GC.GetTotalMemory(false) + " байт");
            Console.WriteLine("Наш объект в поколении: " + GC.GetGeneration(args[0]));
        }
    }
}
