using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task7
{
    class task7
    {
        //7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
        static void Main(string[] args)
        {
            WriteLine("Enter the side of the square: ");
            string str = ReadLine();
            int a = Int32.Parse(str);

            WriteLine("Enter the side of the сircle: ");
            string Str = ReadLine();
            int b = Int32.Parse(str);

            if (a * a > 4 * b * b)
            {
                WriteLine("square of a square(" + (a * a) + ")more area of ​​the circle(" + (4 * b * b) + ")");                
            }
            else
            {
                WriteLine(" more area of ​​the circle (" + (4*b * b) + ")more less of ​​the square(" + (a * a) + ")");
            }
            ReadLine();
        }
    }
}
