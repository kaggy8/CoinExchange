﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desireOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию.");
            Console.WriteLine("1 - обменять рубли на доллары.");
            Console.WriteLine("2 - обменять доллары на рубли.");
            Console.Write("Ваш выбор: ");

            desireOperation = Console.ReadLine();

            switch (desireOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.WriteLine("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Слишком мало денег, милорд!");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.WriteLine("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Слишком мало денег, милорд!");
                    }
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Выбрана не верная операция");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей, " + $"{dollarsInWallet} долларов.");
        }
    }
}
