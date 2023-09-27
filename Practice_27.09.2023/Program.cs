using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2) У Main створити объект, проініціалізувати масив
//використати оператор +
namespace Practice_27._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> arr1 = new MyArray<int>(6);
            Random rnd = new Random();
            for (int i = 0; i < arr1.size; i++)
            {
                arr1[i] = rnd.Next(0,50);
            }
            Random rnd1 = new Random();
            MyArray<int> arr2 = new MyArray<int>(6);
            for (int i = 0; i < arr2.size; i++)
            {
                arr2[i] = rnd1.Next(0,50);
            }
            MyArray<int> arr3 = new MyArray<int>(6);
            arr3 = arr1 + arr2;
            Console.WriteLine("Arr1 = " + arr1);
            Console.WriteLine("Arr2 = " + arr2);
            Console.WriteLine("Arr3 = " + arr3);
        }
    }
}
