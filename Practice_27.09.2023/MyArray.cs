using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//1) Створити класс MyArray
//Поле властивість(get, set) size - int: розмір масива
//Поле - властивість массив int[] arr
//Конструктор, приймає size, виділяє місце у пам'яті під масив arr;
//Перевантажити оператор + (MyArray+MyArray повертаємо MyArray)
//Переробити клас на Узагальнення <T>
//struct
namespace Practice_27._09._2023
{
    internal class MyArray<T> where T : struct
    {
        public int size {get; set;}
        public T[] Arr { get;}
        public MyArray (int s)
        {
            size = s;
            if (s!=0)
            {
                Arr = new T[s];
            }
            else 
                throw new ArgumentException("Error: The array size can not be zero");
        }
        public static MyArray<T> operator +(MyArray<T> a, MyArray<T> b)
        {
            if (a.Arr.Length == b.Arr.Length)
            {
                MyArray<T> c = new MyArray<T>(a.Arr.Length);
                for (int i = 0; i < a.Arr.Length; i++)
                    c.Arr[i] = (dynamic)a.Arr[i] + (dynamic)b.Arr[i];
                return c;
            }
            throw new ArgumentException("The arrays have different sizes");
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < Arr.Length)
                    return (dynamic)Arr[index];
                throw new ArgumentException("Invalid Index");
            }
            set
            {
                if (index >= 0 && index < Arr.Length)
                    Arr[index] = (dynamic)value;
                else
                    throw new ArgumentException("Invalid Index");
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Arr.Length; i++)
            {
                sb.Append(this[i]);
                if (i < Arr.Length - 1)
                    sb.Append(',');
            }
            return sb.ToString();
        }
    }
}
