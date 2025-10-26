using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // 1)
            Console.WriteLine("1)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2)
            Console.WriteLine("2)");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 3)
            Console.WriteLine("3)");
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 4)
            Console.WriteLine("4)");
            for (int i = 0; i < n; i++)
            {
                for (int s = 0; s < i * 2; s++)
                    Console.Write(" ");
                for (int j = i; j < n; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 5)
            Console.WriteLine("5)");
            for (int i = 0; i < n; i++)
            {
                for (int s = 0; s < (n - i - 1) * 2; s++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 6)
            Console.WriteLine("6)");
            // Верхняя часть
            for (int i = 0; i < n; i++)
            {
                for (int s = 0; s < n - i - 1; s++)
                    Console.Write(" ");
                Console.Write("/");
                for (int s = 0; s < i * 2; s++)
                    Console.Write(" ");
                Console.WriteLine("\\");
            }
            // Нижняя часть
            for (int i = n - 1; i >= 0; i--)
            {
                for (int s = 0; s < n - i - 1; s++)
                    Console.Write(" ");
                Console.Write("\\");
                for (int s = 0; s < i * 2; s++)
                    Console.Write(" ");
                Console.WriteLine("/");
            }
            Console.WriteLine();

            // 7)
            Console.WriteLine("7)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("+ ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}