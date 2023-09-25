using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25_09
{
    internal class Bar
    {
        public int Field { get; set; }
        private int[] _Arr = { 1, 2, 3, 4, 5, 6 };

        public static Bar operator +(Bar b, int n)
        {
            return new Bar() { Field = b.Field + n };
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _Arr.Length; i++)
            {
                sb.Append(this[i]);
                if (i < _Arr.Length - 1)
                    sb.Append(',');
            }
            return $"Field: {Field}. Array: {sb.ToString()}";
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _Arr.Length)
                    return _Arr[index];
                throw new ArgumentException("Invalid Index");
            }
            set
            {
                if (index >= 0 && index < _Arr.Length)
                    _Arr[index] = value;
                else 
                    throw new ArgumentException("Invalid Index");
            }
        }
    }
}

