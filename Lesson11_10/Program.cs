using Lesson_11_10;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_10
{
    internal class Program
    {
        private static void PersonGoToWork()
        {
            Console.WriteLine("Go to work");
        }
        private static void PersonGoToHome()
        {
            Console.WriteLine("Go to home");
        }
        static void Main(string[] args)
        {
            #region
            string pathToDir = @"C:\FileSystem\PV_211";
            string pathToFile = pathToDir + @"\data.txt";
            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }
            if (!File.Exists(pathToFile))
            {
               var file= File.Create(pathToFile);
                file.Close();
            }
            Console.WriteLine("Enter message: ");
            string mes = Console.ReadLine();
            File.AppendAllText(pathToFile, mes,Encoding.Unicode);
            //File.WriteAllText(pathToFile, mes, Encoding.Unicode);

            string content = File.ReadAllText(pathToFile);
            Console.WriteLine("Our content: " + content);
            #endregion

            //Person p = new Person() { Name = "Oleg", Age = 30 };
            //p.GoToWork += PersonGoToWork;
            //p.GoToHome += PersonGoToHome;
            //p.GetData(DateTime.Parse("23.09.2021 17:30:12"));


        }
    }
}
