using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Добро пожаловать в счетчик карт в игре 21");
            Write("Введите колличество обычных карт в руке");
            int quantity = int.Parse(ReadLine());
            Write("Введите колличество карт - картинок в руке");
            int icons = int.Parse(ReadLine());
            int summ = 0;
            for (int i = 0; i != quantity; i++)
            {
                Write("Введите вес карты");
                summ = summ + int.Parse(ReadLine());
            }
            WriteLine(summ + icons * 10); // зачем прописывать 21 кейс, если это только увеличит код. Я усвоил оператор swift, но в этом задании им делать - копипастить строки
            ReadKey();

        }
    }
}
