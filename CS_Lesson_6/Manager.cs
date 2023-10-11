using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal class Manager : ISalary, IPrint
    {
        public string fio { get; set; }
        public int numOfWorkDays { get; set; }

        public float CalculateSalary() => numOfWorkDays * 1000;

        public void Print()
        {
            Console.WriteLine(fio + ' ' + numOfWorkDays.ToString() + ' ' + CalculateSalary());
        }
    }
}
