using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal interface ISimpleN_gon
    {
        int NumberOfSides { get; }
        float SideLength { get;  }

        float Square();
        float Perimetr();     
    }
}
