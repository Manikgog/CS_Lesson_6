using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal class Accounting
    {
        public float IncomeTaxCalculation(ISalary working)
        {
            float salary = working.CalculateSalary();
            return salary - (salary/100) * 13;
        }

       

    }
}
