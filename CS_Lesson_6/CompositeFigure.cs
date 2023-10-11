using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal class CompositeFigure : SimpleN_gon
    {
        public float Hight 
        {
            get => Hight; 
            set 
            { 
                if (Hight < 0) 
                { 
                    Console.WriteLine("Число меньше нуля"); 
                    Hight = 0;
                } 
                Hight = value;
            }
        }
        public float BaseLength 
        {
            get => BaseLength;
            set 
            {
                if (BaseLength < 0)
                {
                    Console.WriteLine("Число меньше нуля");
                    BaseLength= 0;
                }
                BaseLength = value;
            }
        }
        public float AngleBetween 
        {
            get => AngleBetween;
            set
            {
                if (AngleBetween <= 0 || AngleBetween >= 180)
                {
                    Console.WriteLine("Число меньше нуля");
                    AngleBetween = 1;
                }
                AngleBetween = value;
            }
        }
        public int NumberOfSides
        {
            get => NumberOfSides;
            set
            {
                if (NumberOfSides < 3)
                {
                    Console.WriteLine("Число меньше нуля");
                    NumberOfSides = 0;
                }
                NumberOfSides= value;
            }
        }
        public float SideLength 
        {
            get => SideLength;
            set
            {
                if (SideLength < 0)
                {
                    Console.WriteLine("Число меньше нуля");
                    SideLength = 0;
                }
                SideLength= value;
            }
        }
        public float Square 
        {
            get 
            {
                Square = (float)(((NumberOfSides * SideLength * SideLength) / 4) + (1 / Math.Abs(Math.Tan(180 / NumberOfSides))));
                return Square;
            }
            set { }
        }
        public float Perimetr 
        {
            get 
            {
                for(int i = 0; i < NumberOfSides; i++)
                {
                    Perimetr += (float)SideLength;
                }
                return Perimetr;
            }
            set { }
        }

        
        int NumbersOfSimpleN_gon { get; set; }
    }
}
