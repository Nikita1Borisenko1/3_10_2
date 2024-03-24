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
            Write("Введите колличество карт в руке");
            int count = Convert.ToInt32(ReadLine());
            int summ = 0;
            for (int i = 0; i < count; i++)
            {
                Write("Введите номер карты (2-10) или же её знак (J,Q,K,T):");
                string userInput = (ReadLine());
                
                switch (userInput)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        summ += 10;
                        break;

                default:
                        bool isNumber = int.TryParse(userInput, out int cardValue);

                        if (isNumber && cardValue >= 2 && cardValue <= 10)
                        {
                            summ += cardValue;
                        }
                        else
                        {
                            WriteLine("Такой карты не бывает");
                            i--;
                        }
                        break;

                }
            }
            WriteLine($"Сумма карт в руке: {summ}");
            ReadKey(true);

        }
    }
}
