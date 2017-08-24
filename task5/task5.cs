using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task5
{
    /*5.	Дано двузначное число. Найти:
            a.	число десятков в нем;
            b.	число единиц в нем;
            c.	сумму его цифр;
            d.	произведение его цифр;
     */
    class task5
    {
        static void Main(string[] args)
        {
            int num = 10;
            WriteLine("Enter a two - digit number:");
            string str = ReadLine();
            int abs = Int32.Parse(str);

            WriteLine("Number of tens in it:"+(abs/num));
            WriteLine("Number of units in it:" + (abs % num));
            WriteLine("The sum of its digits:" + (abs / num) + (abs%num));
            WriteLine("The work of his figures:" + (abs * num));
            ReadLine();
        }
    }
}
