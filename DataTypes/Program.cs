//#define DATA_TYPES
//#define CONSTANTS
#define CONVERSIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        const string delimiter = "\n-------------------------------------\n";
        static void Main(string[] args)
        {
#if DATA_TYPES
            Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
            Console.WriteLine(delimiter);
            Console.WriteLine(bool.FalseString);
            Console.WriteLine(delimiter);
            Console.WriteLine(bool.TrueString);
            Console.WriteLine(delimiter);
            Console.WriteLine(typeof(bool));
            Console.WriteLine(delimiter);

            ////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine($"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значение в диапазоне от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}");
            Console.WriteLine(delimiter);
            Console.WriteLine(@"RAW-строка - игнорирует все специальные символы и Esc - последовательности \t\n, т.е., воспринимается как есть.");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Byte занимает {sizeof(byte)} Байт памяти, и принимает значение в диапазоне от {byte.MinValue} до {byte.MaxValue}, класс-обвертка {typeof(byte)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"SByte занимает {sizeof(sbyte)} Байт памяти, и принимает значение в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвертка {typeof(sbyte)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($@"decimal занимает {sizeof(decimal)} Байт памяти");
            decimal a = 1;
            a /= 3;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);
            Console.WriteLine(delimiter);
#endif
            ////////////////////////////////////////////////////////////////////////////////////////
#if CONSTANTS
            Console.WriteLine("Hello".GetType());
            //Console.WriteLine(typeof("Hello"));
            Console.WriteLine(5.0.GetType());
#endif

#if CONVERSIONS
            int n = 5;
            while (n-- > 0)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(delimiter);
            //ushort b = (ushort)-2;
            //Console.WriteLine(b);
            double a = 2.2;
            short b = (short)a;
            Console.WriteLine(b);
            //bool rain = Convert.ToBoolean("True");
            bool rain = bool.Parse("False");
            Console.WriteLine(rain);
#endif
        }
    }
}
