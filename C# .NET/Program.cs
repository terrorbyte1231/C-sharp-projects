using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rubblesInWallet;
            float dollarsInWallet;
            float exchangeCurrencyCount;

            int rubToUsd = 64, usdToRub = 67;

            string desireOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rubblesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию.");
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.Write("Ваш выбор: ");

            desireOperation = Console.ReadLine();

            switch (desireOperation)
            {
                case "1":
                    Console.Write("Сколько рублей вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());

                    if (rubblesInWallet >= exchangeCurrencyCount)
                    {
                        rubblesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                        Console.WriteLine($"Вы обмениваете {exchangeCurrencyCount} рублей на {exchangeCurrencyCount / rubToUsd} долларов");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно рублей для данной операции");
                    }

                    Console.WriteLine($"В вашем кошельке {rubblesInWallet} рублей и {dollarsInWallet} долларов");
                    break;
                case "2":
                    Console.Write("Сколько долларов вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());

                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rubblesInWallet += exchangeCurrencyCount * usdToRub;
                        Console.WriteLine($"Вы обмениваете {exchangeCurrencyCount} долларов на {exchangeCurrencyCount * usdToRub} рублей");
                    } 
                    else
                    {
                        Console.WriteLine("У вас недостаточно долларов для данной операции");
                    }

                    Console.WriteLine($"В вашем кошельке {rubblesInWallet} рублей и {dollarsInWallet} долларов");
                    break;
                default:
                    Console.WriteLine("Введено некорректное значение!");
                    break;
            }


        }
    }
}