﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Console.Title = "Kuju valimine ja arvutamine"; //aknale nime panemine
            Console.WriteLine("Vali, mis kujundit soovid arvutada ja kujutada ning kirjuta konsoolile");

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");
            Console.WriteLine("5. Maja");

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "ruut":
                    Quadrilateral();
                    break;

                case "teemant":
                    Diamond();
                    break;

                case "ristkülik":
                    Rectangle();
                    break;

                case "kolmnurk":
                    Triangle();
                    break;

                case "maja":
                    House();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
            //goto Start;



        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites: ");
            double quadrilateral = double.Parse(Console.ReadLine());

            Console.WriteLine("Ruudu ümbermõõt: " + 4 * quadrilateral);
            Console.WriteLine("Ruudu pindala: " + quadrilateral * quadrilateral);
            //Math.PI;

            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Diamond()
        {
            double i, j, diamond;

            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            diamond = double.Parse(Console.ReadLine());

            //teemandi raadius on 4
            Console.WriteLine("Ringi ümbermõõt: " + 2 * Math.PI * diamond);
            Console.WriteLine("Ringi pindala" + Math.PI * (diamond * diamond));



            for (i = 0; i <= diamond; i++)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = diamond - 1; i >= 1; i--)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        private static void Rectangle()
        {
            Console.WriteLine("\nSisesta ristküliku kahe külje mõõtühik sentimeetrites");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("ristküliku ümbermõõt: " + 2 * (a + b));
            Console.WriteLine("ristküliku pindala:" + (a * b));



            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            Console.WriteLine("\nSisesta v]rdk[lgse kolmnurga k[lje pikkus sentimeetrites");

            double length = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("kolmnurga pindala: " + length * h / 2);
            Console.WriteLine("kolmnurga ümbermõõt: " + 3 * length);



            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = " ";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if (row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        public static void House()
        {
            int i, j, spc, rows, k;

            Console.WriteLine("\nSisesta maja suurus: ");
            int quadrilateral = int.Parse(Console.ReadLine());

            //katus
            spc = quadrilateral + 4 - 1;

            for (i = 1; i <= quadrilateral; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }

            //korrus
            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = " " + " *";
                    }
                    else
                    {
                        mark = " " + " *";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}