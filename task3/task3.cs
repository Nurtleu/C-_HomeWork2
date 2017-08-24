using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task3
{
    class task3
    {
        //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        static void Main(string[] args)
        {
            WriteLine("Enter in centimeters:");
            string str = ReadLine();
            int cm = Int32.Parse(str);
            WriteLine("In" + str + " centimeters " + cm / 100 + " meters ");

            WriteLine("Enter in meters:");
            string Str = ReadLine();
            int metr = Int32.Parse(Str);
            WriteLine("In" + str + "meters" + metr * 100 + "centimeters");
            ReadLine();
        }
    }
}
