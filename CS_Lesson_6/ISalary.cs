using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal interface ISalary
    {
        string fio { get; set; }
        int numOfWorkDays { get; set; }
        float CalculateSalary();

        void Print();
    }
}
