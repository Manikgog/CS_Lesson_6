using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_6
{
    internal interface Interface1
    {
        int C { get; set; }
        void Ball();
    }

    internal class Cl { }

    internal class Cl3 : Cl, Interface1
    {
        int Interface1.C { get; set; }
        

        public void Ball()
        {
            Console.WriteLine("Cl3");
        }
    }

    
}
