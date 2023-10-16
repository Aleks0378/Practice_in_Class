using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_10
{
    [Serializable]
    internal class Product
    {
        public int[] ints;
        public string Name { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }
        public Product(string name, int id, float price, int[] arr)
        {
            ints = arr;
            Name = name;
            Id = id;
            Price = price;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}
