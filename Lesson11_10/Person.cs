using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_10
{
    public delegate void PersonDelegate();
    internal class Person
    {
        public event PersonDelegate GoToWork;
        public event PersonDelegate GoToHome;
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetData(DateTime dt)
        {
            if(dt.Hour>=6 && dt.Hour<=8) 
            {
                GoToWork?.Invoke();
            }
            else if (dt.Hour >= 17 && dt.Hour <= 20)
            {
                GoToHome?.Invoke();
            }
        }

        public override string ToString()
        {
            return $"Name {Name}, Age {Age}";
        }
    }
}
