//#define DATA_TYPES
//#define CONSTANTS
#define DATA_TYPES_HOMEWORK
//#define CONVERSIONS
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

#if DATA_TYPES_HOMEWORK
            Console.WriteLine($"Тип данных int занимает {sizeof(int)} Байт памяти, и принимает значение в диапазоне от {int.MinValue} до {int.MaxValue}. Класс-обвертка - {typeof(int)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных uint занимает {sizeof(uint)} Байт памяти, и принимает значение в диапазоне от {(int)uint.MinValue} до {uint.MaxValue}. Класс-обвертка - {typeof(uint)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных short занимает {sizeof(short)} Байт памяти, и принимает значение в диапазоне от {short.MinValue} до {short.MaxValue}. Класс-обвертка - {typeof(short)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных ushort занимает {sizeof(ushort)} Байт памяти, и принимает значение в диапазоне от {(int)ushort.MinValue} до {(int)ushort.MaxValue}. Класс-обвертка - {typeof(ushort)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных long занимает {sizeof(long)} Байт памяти, и принимает значение в диапазоне от {long.MinValue} до {long.MaxValue}. Класс-обвертка - {typeof(long)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных ulong занимает {sizeof(ulong)} Байт памяти, и принимает значение в диапазоне от {(int)ulong.MinValue} до {ulong.MaxValue}. Класс-обвертка - {typeof(ulong)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значение в диапазоне от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Byte занимает {sizeof(byte)} Байт памяти, и принимает значение в диапазоне от {byte.MinValue} до {byte.MaxValue}, класс-обвертка {typeof(byte)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"SByte занимает {sizeof(sbyte)} Байт памяти, и принимает значение в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвертка {typeof(sbyte)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"decimal занимает {sizeof(decimal)} Байт памяти, класс обвертка {typeof(decimal)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка {typeof(bool)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных float занимает {sizeof(float)} Байт памяти, и принимает значение в диапазоне от {float.MinValue} до {float.MaxValue}. Класс-обвертка - {typeof(float)}");
            Console.WriteLine(delimiter);
            Console.WriteLine($"Тип данных double занимает {sizeof(double)} Байт памяти, и принимает значение в диапазоне от {double.MinValue} до {double.MaxValue}. Класс-обвертка - {typeof(double)}");
            Console.WriteLine(delimiter);
#endif
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

/*
Типы данных:

С# является полностью объектно-ориентированным языком программирования и это отображается на его типах данных, которые выстроены в иерархии. Абсолютно все типы данных в языке C# являются объектами, то есть наследованы от самого базового типа object. Тип object включает в себя несколько методов:

equals()
referenceequals()
gettype()
tostring()

Все типы данных можно разделить на два класса:

1)Значимые (valuetypes)
2)Ссылочные (referencetypes)

Значимые типы непосредственно хранят значение. К ним относятся bool, char, byte, short, int, long, float, double, decimal, enum.
Ссылочные типы не содержат значение непосредственно, а лишь хранят ссылку на значение в динамической памяти. К ссылочным типам относятся array, string, class, struct.

Благодаря тому, что значимые типы являются объектами, у каждого из них есть так называемый класс "обвертка" (wrapper). Он содержит некую информацию о типе и позволяет выполнять некоторые операции над типом.

Числовые типы:

Так же как в языке C++ числовые типы делятся на целочисленные и вещественные.

Для целочисленных типов отсутствует ключевое слово unsigned, а для беззнаковых типов выделены отдельные спецификаторы:
ushort
uint
ulong

Наименьшим целочисленным типом является байт. По умолчанию, этот тип является беззнаковым. Для того, чтобы объявить знаковый байт используют спецификатор sbyte (Signed Byte).

sbyte byte 1 Байт
sshort ushort 2 Байта
int uint 4 Байта
long ulong 8 Байт

У знакового типа и его беззнакового аналога разные классы-обвертки

Вещественные типы:

Так же, как в языке C++, в C# есть типы float и double, которые являются точными аналогами из C++.
Их недостатком является точность, поэтому их ни в коем случае нельзя использовать для финансовых вычислений. Именно для этих целей в платформе .NET существует тип данных decimal. Он занимает 16 байт памяти и может хранить до 28 знаков после запятой, но decimal хранит абсолютно точное значение.

Константы:

Строковые константы так же являются объектами. Тип константы всегда можно узнать при помощи метода gettype() из базового типа object.

В языке C# используется строгая типизация данных, которая строго запрещает неявные преобразование от большего к меньшему, такие преобразования можно выполнять только явным образом. Сюда относятся в частности неявное преобразование числовых типов в bool. Строгая типизация так же запрещает преобразование беззнаковых типов в знаковые и наоборот.

Если неявное преобразование запрещено, то можно совершить явное преобразование даже с потерей данных.

Для явных преобразований используется только C-Like notation. Когда желаемый тип пишется в круглых скобках перед значением (type)value. C-Like notation подходит лишь для преобразований возможных на аппаратном уровне.

Преобразование требующее определенного алгоритма, выполняются только при помощи класса convert.

*/