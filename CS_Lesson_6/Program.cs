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

            Task_2();
            
            
        }

        public static void Task_2()
        {
            /*Реализовать интерфейс ПростойНУгольник, который
        имеет свойства: Высота, Основание, УголМеждуОснованиемИСмежнойСтороной, 
        КоличествоСторон, ДлиныСторон, Площадь, Периметр.
        Реализовать класс СоставнаяФигура который может
        состоять из любого количества ПростыхНУгольников.
        Для данного класса определить метод нахождения площади фигуры.
        Предусмотреть варианты невозможности задания
        фигуры (введены отрицательные длины сторон или при
        создании объекта треугольника существует пара сторон,
        сумма длин которых меньше длины третьей стороны и т.п.)
             */

            /*
             Решение задачи. Для вычисления площади простого н-угольника явно недостаточно
        входных данных: мало одного угла между основанием и смежной стороной. Нужны все углы 
        либо координаты точек вершин. Есть и избыточные данные, 
        такие как Основание и высота. Поэтому задачу решил для правильного простого многоугольинка
        с использованием следующих свойств: 
        ДлиныСторон, КоличествоСторон, КоличествоПростыхНУгольников.
            */
            Console.Write("Введите количество сторон правильного простого многоугольника: ");

            int numberOfSides = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину стороны (см): ");

            float sideLength = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество многоугольников: ");

            int numberOfSimpleN_gon = Convert.ToInt32(Console.ReadLine());

            ISimpleN_gon triangle = new CompositeFigure(numberOfSides, sideLength, numberOfSimpleN_gon);

            Console.WriteLine("Площадь " + numberOfSimpleN_gon + " " + numberOfSides + "-угольников равна ->"  + " " + triangle.Square() + " кв.см");
            Console.WriteLine("Периметр " + numberOfSimpleN_gon + " " + numberOfSides + "-угольников равен ->"  + " " + triangle.Perimetr() + " см");


        }
    }


}
