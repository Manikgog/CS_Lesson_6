using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal class CompositeFigure : ISimpleN_gon
    {
               
        private float ConvertToRadians(float angle)
        {
            return (float)(Math.PI / 180) * angle;
        }

        public CompositeFigure(int numberOfSides, float sideLength, int numberOfSimpleN_gon)
        {
            if (numberOfSides <= 2)
            {
                if (numberOfSides < 0)
                {
                    Console.WriteLine("Количество сторон не может быть меньше нуля.");
                }
                else
                {
                    Console.WriteLine("Слишком малое количество сторон.");
                }
                numberOfSides = 1;
            }
            if (sideLength < 0.000001f)
            {
                Console.WriteLine("Слишком маленькая длина стороны.");
                sideLength = 0.0f;
            }
            if(numberOfSimpleN_gon < 1)
            {
                Console.WriteLine("Количество n-угольников не может быть меньше одного.");
                numberOfSimpleN_gon = 1;
            }
            this.NumberOfSides = numberOfSides;
            this.SideLength = sideLength;
            this.NumbersOfSimpleN_gon = numberOfSimpleN_gon;
        }
        
        public int NumberOfSides
        {
            get; 
        }
        public float SideLength
        {
            get; 
        }

        public float Square()
        {
            if(NumberOfSides < 3 || SideLength == 0.0f)
            {
                return 0;
            }
            float Tan = (float)Math.Abs(Math.Tan(ConvertToRadians(180/NumberOfSides)));

            float a = NumberOfSides * SideLength * SideLength;

            float squareOfOneFigure = (float)(a/(4*Tan));

            return NumbersOfSimpleN_gon * squareOfOneFigure;
        }
        public float Perimetr()
        {
            if(NumberOfSides < 1)
            {
                return 0;
            }
            else if (NumberOfSides < 3 || SideLength == 0.0f)
            {
                return SideLength;
            }
            float overAllPerimetr = SideLength * NumberOfSides * NumbersOfSimpleN_gon - (NumbersOfSimpleN_gon - 2 + NumbersOfSimpleN_gon) * SideLength;

            return overAllPerimetr;
           
        }

        
        int NumbersOfSimpleN_gon { get; set; }
    }
}
