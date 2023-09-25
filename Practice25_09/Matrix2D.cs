using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Создать класс Matrix2D, представляющий матрицу,
//перегрузить операторы + и - для выполнения операций сложения и вычитания матриц.
//Зробити індексатори.
//Перевантажити оператор >= який перевіряє яка матриця по сумі усіх елементів більша.
namespace Practice25_09
{
    internal class Matrix2D
    {
        public int[,] _Arr = new int[5, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };

        public static Matrix2D operator +(Matrix2D m1, Matrix2D m2)
        {
            int[,] arr = new int[m1._Arr.GetLength(0), m1._Arr.GetLength(1)];
            for (int i = 0; i < m1._Arr.GetLength(0); i++)
            {
                for (int j = 0; j < m1._Arr.GetLength(1); j++)
                {
                    arr[i, j] = m1._Arr[i, j] + m2._Arr[i, j];
                }

            }
            return new Matrix2D(){ _Arr=arr };
        }
        public static Matrix2D operator -(Matrix2D m1, Matrix2D m2)
        {
            int[,] arr = new int[m1._Arr.GetLength(0), m1._Arr.GetLength(1)];
            for (int i = 0; i < m1._Arr.GetLength(0); i++)
            {
                for (int j = 0; j < m1._Arr.GetLength(1); j++)
                {
                    arr[i, j] = m1._Arr[i, j] - m2._Arr[i, j];
                }

            }
            return new Matrix2D() { _Arr = arr };
        }

        public static bool operator >=(Matrix2D m1, Matrix2D m2)
        {
            int s1 = 0, s2 = 0;
            foreach (var i in m1._Arr)
                s1 += i;
            foreach (var k in m2._Arr)
                s2 += k;
            return s1 >= s2;
        }

        public static bool operator <=(Matrix2D m1, Matrix2D m2)
        {
            int s1 = 0, s2 = 0;
            foreach (var i in m1._Arr)
                s1 += i;
            foreach (var k in m2._Arr)
                s2 += k;
            return s1 <= s2;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i <_Arr.GetLength(0); i++)
            {
                for (int j = 0; j < _Arr.GetLength(1); j++)
                {
                    sb.Append(this[i, j]);
                    if (j < _Arr.GetLength(1) - 1)
                        sb.Append(',');
                }
                if (i < _Arr.GetLength(0) - 1)
                    sb.Append("; ");
            }
            return $"Array: {sb.ToString()}";
        }


        public int this[int index0, int index1]
        {
            get
            {
                if (index0 >= 0 && index0 < _Arr.GetLength(0) && index1 >= 0 && index1 < _Arr.GetLength(1))
                    return _Arr[index0, index1];
                throw new ArgumentException("Invalid Index");
            }
            set
            {
                if (index0 >= 0 && index0 < _Arr.GetLength(0) && index1 >= 0 && index1 < _Arr.GetLength(1))
                    _Arr[index0, index1] = value;
                else
                    throw new ArgumentException("Invalid Index");
            }
        }
    }
}
