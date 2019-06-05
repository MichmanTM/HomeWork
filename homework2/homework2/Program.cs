using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void pause()
        {
            Console.ReadLine();
        }

        static int count(string s)
        {
            return s.Length;
        }

        private static int ret(int a, int b, int c)
        {
            int min = 0;

            if (a <= b && a <= c)
            { min = a; }
            else if (b <= a && b <= c)
            { min = b; }
            else if (c <= a && c <= b)
            { min = c; }

            return min;
        }

        static void Main(string[] args)
        {
            #region hm1
            //Console.Write(" a = ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" b = ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" c = ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int min = ret(a, b, c);

            //Console.WriteLine($"min = {min}");



            //pause();

            #endregion

            #region hm2

            //    Console.Write("Число: ");                                               
            //    Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));

            //pause();
            #endregion

            #region hm3

            //int sum = 0;
            //int num = 0;

            //do
            //{
            //    num = int.Parse(Console.ReadLine());  // в переменную num кладем число ;
            //    if (num > 0 && num % 2 == 1)          //  проверяем переменную  num  и делем ее на 2 с остатком ;
            //        sum += num;                       // с кладываем все нечетные значения в переменную;

            //} while (num != 0);                       // выполняем если num не равен "0"; 

            //Console.WriteLine("Sum: " + sum);

            //pause();
            #endregion

            #region hm4
            string log = "root";
            string pass = "GeekBrains";
            int i = 0;

            string log1 = null;
            string pass1 = null;
            do
            {

                Console.Write($"введите логин");
                log1 = Console.ReadLine();
                Console.Write($"введите пароль");
                pass1 = Console.ReadLine();

                i++;

                if (i>=3)
                {
                   Console.Write($"Вы сделали " + i + " максимальных попыток ввода");
                   return; 
                }

            }
            
            while (log != log1 && pass != pass1);          // Повторять пока условие истинно(true)
            Console.Write($"логин и пароль совподают проходите");
            pause();
            

            
            #endregion
        }



    }
}
