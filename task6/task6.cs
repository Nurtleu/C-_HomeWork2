using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task6
{
    class task6
    {
        /*6. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
             a.А или В; 
             b.А и В; 
             c.В или С.
        */
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = false;
            bool resFirst = a || b;
            bool resSecond = a && b;
            bool resThird = b || c;
            WriteLine("A or B {0}", resFirst);
            WriteLine("A and B {0}", resSecond);
            WriteLine("B or C {0}", resThird);
            ReadLine();
        }
    }
}
