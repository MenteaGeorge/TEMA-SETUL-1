﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_SETUL_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            // Problema6();
            //Problema7();
            //Problema8();
            // Problema9();
            //Problema10();
            //Problema11();
            //Problema12();
            //Problema13();
            //Problema14();
            // Problema15();
            //Problema16();
            //Problema17();
            //Problema18();
            //Problema19();
            // Problema20();
            // Problema21();
        }

        private static void Problema21()
        {
            int ok = 1;
            int k;
            var range = 1024;
            Random rnd = new Random();
            int x = rnd.Next(range);
            Console.WriteLine("Introdu un numar");
            while (ok != 0)
            {
                k = int.Parse(Console.ReadLine());
                if (k == x)
                {
                    Console.WriteLine("Ati ghicit numarul");
                    ok = 0;
                }
                else
                    if (k < x)
                {
                    Console.WriteLine("Numarul introdus este prea mic");

                }
                else
                {
                    Console.WriteLine("Numarul introdus este prea mare");
                }
            }
        }

        private static void Problema20()
        {
            throw new NotImplementedException();
        }

        private static void Problemma19()
        {
            int n, a, b, ok = 0;
            Console.WriteLine("Introduceti un nuamr");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti doua cifre pentru a verifica numarul");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


            if ((n % 10 == a) || (n % 10 == b))
            {
                ok = 1;
                n /= 10;
            }
            else
                ok = 0;

            if (ok != 0)
                Console.WriteLine("Numarul ales poate fi format doar din cifre " + a + " si " + b);
            else
                Console.WriteLine("Nu este posibil");
        }

        private static void Problema18()
        {
            Console.WriteLine("Introdu numarul n");
            int n = int.Parse(Console.ReadLine());
            
            int s;
            while (n > 0)

            {
                for (int i = 2; i <= n; i++)
                {
                    s = 0;
                    while (n % i == 0)
                    {
                        s++;
                        n = n / i;
                    }
                    if (s != 0)

                    {

                        Console.Write($"{i}^{s}");
                    }
                    if (n>1)
                    {
                        Console.WriteLine("x");
                    }


                }
                Console.WriteLine();


            }
        }

        private static void Problema17()
        {
            int divizor;
            int multiplu;
            
            Console.Write("Introduce pe X si Y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                if (x % y == 0)
                    divizor = y;
                else
                    divizor = x % y;

            }
            else
            {
                if (y % x == 0)
                    divizor = x;
                else
                    divizor = y % x;
            }

            multiplu = (x * y) / divizor;


            Console.WriteLine("CMMDC este " + divizor);
            Console.WriteLine("CMMMC este " + multiplu);
        }

        private static void Problema16()
        {
            int a, b, c, d, e;

            Console.WriteLine("Introduceti pe a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti pe b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti pe c: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti pe d: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti pe e: ");
            e = Convert.ToInt32(Console.ReadLine());

            // Sortarea manuală a variabilelor
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }

            if (d > e)
            {
                int temp = d;
                d = e;
                e = temp;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }


            Console.WriteLine($"Numerele în ordine crescătoare sunt: {a}, {b}, {c}, {d}, {e}");
        }


        private static void Problema15()
        {
            Console.WriteLine("Introduceti numerele a,b,c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine($"Numere in ordine crescatoare sunt {a} {b} {c}");
        }

        private static void Problema14()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int s = n;
            while (n > 0)
            {
                int b = n % 10;
                k = (k * 10) + b;
                n = n / 10;

            }
            if (s == k)
            {
                Console.WriteLine($"Nmarul n={s} este palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul n={s} nu este palindrom");
            }
        }

        private static void Problema13()
        {
            Console.Write("Introduceti anul y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti anul y2");
            int y2 = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    contor++;
                }
            }
            if (contor == 0)

                Console.WriteLine($"Nu exista niciun an bisect intre anii {y1} si {y2}");
            else
                Console.WriteLine($"Intre anii {y1} si {y2} sunt {contor} ani bisecti");

        }

        private static void Problema12()
        {
            Console.Write("Introduceti pe a si b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("Intordu pe n");
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                { contor++; }
            }
            Console.WriteLine($"Intre a si b sunt {contor} numere divizibile cu n");
        }

        private static void Problema11()
        {
            Console.Write("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int k = n % 10;
                Console.Write($" {k} ");
                n = n / 10;
            }
        }

        private static void Problema10()
        {
            Console.Write("Introduceti pe n");
            int n = int.Parse(Console.ReadLine());
            int ok = 1;
            if (n == 1 || n == 0)
            {
                Console.WriteLine(" nu e prim");
                ok = 0;

            }
            else
            {

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        ok = 0;
                    }

                }
            }
            if (ok == 1)
            {
                Console.WriteLine("N este prim");
            }
            else
            {
                Console.WriteLine("N  nu este prim");
            }

        }

        private static void Problema9()
        {
            Console.WriteLine("introduceti n");
            double n = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static void Problema8()
        {
            Console.Write("Introdu a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introdu b");
            double b = Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Numere inversate sunt a={a} , b={b}");
        }

        private static void Problema7()
        {
            Console.WriteLine("Introdu a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdu b");
            double b = Convert.ToDouble(Console.ReadLine());

            double temp;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"Numere inversate sunt a={a} , b={b}");
        }

        private static void Problema6()
        {
            Console.Write("introdu pe a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introdu pe b");
            int b = int.Parse(Console.ReadLine());
            Console.Write("introdu pe c");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)

            {
                Console.WriteLine($"Laturile a={a} , b={b} ,c={c} pot forma un triunghi");
            }
        }

        private static void Problema5()
        {
            Console.WriteLine("Introdu n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("introdu k");
            int k = int.Parse(Console.ReadLine());


            int contor = 0;
            int ok = 0;

            while (n > 0)
            {
                int cifrak = n % 10;
                n = n / 10;
                contor++;



                if (contor == k)

                {
                    ok = 1;
                    Console.WriteLine($"A {k}-a cifra a numarului n este {cifrak}");
                    break;
                }

            }
            if (ok == 0)
            Console.WriteLine("K nu e valid");


        }


        private static void Problema4()
        {
            Console.Write("Introduceti anul y");
            int y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                Console.WriteLine($"{y} este un an bisect.");
            }
            else
            {
                Console.WriteLine($"{y} nu este un an bisect.");
            }
        }

        private static void Problema3()
        {
            Console.WriteLine("Introdu n");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdu k");
            double k = Convert.ToDouble(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("n se divide cu k");

            }
            else
            {
                Console.WriteLine("n nu se divide cu k");
            }
        }

        private static void Problema2()
        {
            Console.Write("Introduceti  a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti  b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti  c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Solutiile ecuatiei sunt " + a + "x^2 + " + b + "x + " + c + " = 0 sunt x1 = " + x1 + " și x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Ecutia are o soluția dubla: x = " + x);
            }
            else
            {
                Console.WriteLine("Ecutia nu are solutii reale.");
            }
        }

        private static void Problema1()
        {
            Console.WriteLine("Introduceti pe A si B");
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are o infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutie.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Solutia este x = {x}");
            }
        }


    }
}



