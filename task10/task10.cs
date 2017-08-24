using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task10
{
    class task10
    {
        /*
             1.	Напечатать "столбиком": 
             a.	все целые числа от 20 до 35;
             b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
             c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
             d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
        */
        static void Main(string[] args)
        {

            Write("All integers from 20 to 35:");
            int first = 20;
            int last = 35;
            for (int i = first; i < last; i++)
            {
                Write(i + " ");
            }

            WriteLine("\nb. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);");
            WriteLine("Enter the number b:");
            string str = ReadLine();
            int b = Int32.Parse(str);
            if (b < 10)
            {
                WriteLine("Value entered incorrectly!");
                WriteLine("Enter the number b:");
                str = ReadLine();
                b = Int32.Parse(str);
            }
            else
            {
                for (int i = 10; i < b; i++)
                {
                    Write(Math.Pow(i, 2) + " ");
                }
            }

            WriteLine("\nc.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50)");
            WriteLine("Enter the number a:");
            string Str = ReadLine();
            int c = Int32.Parse(Str);
            for (int i = c; i < 50; i++)
            {
                WriteLine(Math.Pow(i,3));
            }

            WriteLine("все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a)");
            WriteLine("Enter the number a:");
            string StrO = ReadLine();
            int m = Int32.Parse(StrO);

            WriteLine("Enter the number b:");
            string StrB = ReadLine();
            int d = Int32.Parse(StrB);

            for (int i=m; i<d; i++)
            {
                WriteLine(i);
            }
            ReadLine();
        }
    }
}
