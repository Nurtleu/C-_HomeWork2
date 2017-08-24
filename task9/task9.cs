using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task9
{
    class task9
    {
        // 9.	 Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
        static void Main(string[] args)
        {
            WriteLine("Cопротивление 1-го электрического цепа:");
            string strOne = ReadLine();
            int EOne = Int32.Parse(strOne);

            WriteLine("Напряжение 1-го электрического цепа:");
            string StrOne = ReadLine();
            int NOne = Int32.Parse(StrOne);

            WriteLine("Cопротивление 2-го электрического цепа:");
            string strTwo = ReadLine();
            int ETwo = Int32.Parse(strTwo);

            WriteLine("Напряжение 2-го электрического цепа:");
            string StrTwo = ReadLine();
            int NTwo = Int32.Parse(StrTwo);

            WriteLine("Cопротивление 1-го электрического цепа("+(EOne/NOne)+")Напряжение 1-го электрического цепа("+ (NOne / EOne) +")");
            WriteLine("Cопротивление 2-го электрического цепа("+(ETwo/NTwo)+ ")Напряжение 2-го электрического цепа("+ (NTwo / ETwo) +")");
            ReadLine();
        }
    }
}
