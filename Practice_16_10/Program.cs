using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1:
//Для масиву цілих реалізуйте наступні запити:
// Отримати весь масив цілих.
// Отримати парні цілі.
// Отримати непарні цілі.
// Отримати значення більше заданого.
// Отримати числа в заданому діапазоні.
// Отримати числа, кратні семи. Результат відсортуйте за зростанням.
// Отримати числа, кратні восьми. Результат відсортуйте за спаданням.
namespace Practice_16_10
{ 
    internal class Program
    {

        static void Main(string[] args)
        {
        int[] arr = new int[20];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
                arr[i] = random.Next(0,50);
        }
        Console.WriteLine("Отримати весь масив цілих.");
        var arr2 = from i in arr
                   select i;
            foreach (var item in arr2)
                Console.Write("{0}  ",item);
            Console.WriteLine();
            Console.WriteLine("Отримати парні цілі.");
            arr2 = from i in arr
                   where i%2==0
                   select i;
            foreach (var item in arr2)
                Console.Write("{0}  ", item);
            Console.WriteLine();
            Console.WriteLine("Отримати непарні цілі.");
            arr2 = from i in arr
                   where i % 2 != 0
                   select i;
            foreach (var item in arr2)
                Console.Write("{0}  ", item);
            Console.WriteLine("Отримати значення більше заданого.");
            Console.WriteLine("\n\nEnter integer number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            arr2 = from i in arr
                   where i >num
                   select i;
            foreach (var item in arr2)
                Console.Write("{0}  ", item);
            Console.WriteLine("Отримати числа в заданому діапазоні.");
            Console.WriteLine("\n\nEnter first integer number of the rate: ");
            num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number of the rate: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> arr3 = arr.Where(i => i > num && i < num2);
            foreach (var item in arr3)
                Console.Write("{0}  ", item);
            Console.WriteLine("\n\n Отримати числа, кратні семи. Результат відсортуйте за зростанням.");
            arr3=arr.Where(i=>i%7==0).OrderBy(i=>i);
            foreach (var item in arr3)
                Console.Write("{0}  ", item);
            Console.WriteLine("\n\n Отримати числа, кратні восьми. Результат відсортуйте за спаданням.");
            arr3 = arr.Where(i => i % 8 == 0).OrderByDescending(i => i);
            foreach (var item in arr3)
                Console.Write("{0}  ", item);
        }
    }
}
