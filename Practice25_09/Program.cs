using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать класс Matrix2D, представляющий матрицу,
//перегрузить операторы + и - для выполнения операций сложения и вычитания матриц.
//Зробити індексатори.
//Перевантажити оператор >= який перевіряє яка матриця по сумі усіх елементів більша.
namespace Practice25_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix2D b1 = new Matrix2D();
            Matrix2D b2 = new Matrix2D();
            Matrix2D b3 = b1+ b2;
            Console.WriteLine($"Array1: {b1}");
            Console.WriteLine($"Array2: {b2}");
            Console.WriteLine($"Array3: {b3}");
            try
            {
                Console.WriteLine(b2[0,0]);
                Console.WriteLine("enter Value: ");
                int value = Convert.ToInt32(Console.ReadLine());
                b2[0,0] = value;
                Console.WriteLine(b2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
