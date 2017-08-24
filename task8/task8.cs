using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task8
{
    class task8
    {
        //8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        static void Main(string[] args)
        {
            WriteLine("Enter the amount of the first material:");
            string str = ReadLine();
            int VolOne = Int32.Parse(str);

            WriteLine("Enter the amount of the second material:");
            string Str = ReadLine();
            int VolTwo = Int32.Parse(Str);

            WriteLine("Enter the mass of the first material: ");
            string strTwo = ReadLine();
            int MasOne = Int32.Parse(strTwo);

            WriteLine("Enter the mass of the second material: ");
            string StrTwo = ReadLine();
            int MasTwo = Int32.Parse(StrTwo);

            if (VolOne * MasOne> VolOne * MasTwo)
            {
                WriteLine("Enter the amount of the first material("+(VolOne*MasOne)+")Enter the mass of the first material(" + (VolTwo * MasTwo)+")");
            }
            else
            {
                WriteLine("Enter the amount of the second material("+(VolTwo*MasTwo)+ ")Enter the mass of the second material(" + (VolOne * MasOne)+")");
            }

            ReadLine();
        }
    }
}
