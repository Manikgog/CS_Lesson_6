using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ISalary managerSalary = new Manager();
            //managerSalary.fio = "Joe Tribiani";
            //managerSalary.numOfWorkDays = 30;
            //managerSalary.Print();

            //ISalary headDepartment = new HeadDepartment();
            //headDepartment.fio = "Chendler Bing";
            //headDepartment.numOfWorkDays = 30;
            //headDepartment.Print();
            //Accounting accounting = new Accounting();
            //accounting.IncomeTaxCalculation(managerSalary);
            //accounting.IncomeTaxCalculation(headDepartment);

            SimpleN_gon triangle = new CompositeFigure();

            triangle.AngleBetween = 60;
            triangle.NumberOfSides = 3;
            triangle.SideLength = 10;
            triangle.Hight = 5;
            triangle.BaseLength = 10;
            Console.WriteLine(triangle.Square);

        }
    }


}
