using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_12_10
{
    internal class Program
    {
        static void WriteFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath,
            FileMode.Create, FileAccess.Write,
            FileShare.None))
            {
                // получаем данные для записи в файл
                WriteLine("Enter the data to write to the file: ");

                string writeText = ReadLine();
                // преобразуем строку в массив байт
                byte[] writeBytes = Encoding.Default.
                GetBytes(writeText);
                // записываем данные в файл
                fs.Write(writeBytes, 0, writeBytes.Length);
                WriteLine("Information recorded!");
            }
        }
        static string ReadFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath,
            FileMode.Open, FileAccess.Read,
            FileShare.Read))
            {
                byte[] readBytes = new byte[(int)fs.Length];
                // считываем данные из файла
                fs.Read(readBytes, 0, readBytes.Length);
                // преобразуем байты в строку
                return Encoding.Default.
                GetString(readBytes);
            }
        }
        static void Main(string[] args)
        {
            string pathToFile = "product.json";
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Product prod1 = new Product("Apple", 5, 1.54f, arr);
            //using (FileStream fs = new FileStream("product.bin", FileMode.Create))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs, prod1);
            //}
            //using (FileStream fs = new FileStream("product.bin", FileMode.Open))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    Product obj = (Product)bf.Deserialize(fs);
            //    Console.WriteLine(obj);
            //    Console.Write("ints: {");
            //    foreach (int i in obj.ints)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.Write("}\n");
            //}


            string json = JsonConvert.SerializeObject(prod1);
            //Console.WriteLine(json);
            File.WriteAllText(pathToFile, json);
            Product prod2 = JsonConvert.DeserializeObject<Product>(File.ReadAllText(pathToFile));
            Console.WriteLine(prod2);
            foreach (int i in prod2.ints)
            {
                Console.Write(i);
            }
            Console.Write("}\n");
        }
    }
}
