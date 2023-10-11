using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal interface SimpleN_gon
    {
        float Hight { get; set; }
        float BaseLength { get; set; }
        float AngleBetween { get; set; }
        int NumberOfSides { get; set; }
        float SideLength { get; set; }

        float Square { get; set; }

        float Perimetr { get; set; }

        
     
    }
}
