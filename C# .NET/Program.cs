using System;

namespace C_.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALC Everything!!!");

            while (true)
            {
                Console.WriteLine("Что вы хотите посчитать?");
                Console.WriteLine("1 - обычный калькулятор");
                Console.WriteLine("2 - обменник курс доллар/рубль");
                Console.WriteLine("3 - конвертер миль в км");
                Console.WriteLine("4 - индекс массы тела");
                Console.WriteLine("5 - необходимое число калорий в день");
                Console.WriteLine("6 - високосность года");
                Console.Write("Введите ваш выбор: ");

                int workModeChoose; // Выбор режима работы программы
                workModeChoose = Convert.ToInt32(Console.ReadLine());

                switch (workModeChoose)
                {
                    case 1:
                        string conditionCalc1 = "Да";
                        while (conditionCalc1 == "Да")
                        {
                            Console.WriteLine("'+' - сложение");
                            Console.WriteLine("'-' - вычитание");
                            Console.WriteLine("'*' - умножение");
                            Console.WriteLine("'/' - деление");
                            Console.WriteLine("'%' - остаток от деления");
                            Console.Write("Выберите операцию: ");

                            string operationChoose;
                            operationChoose = Console.ReadLine();

                            Console.WriteLine("Введите числа которые хотите посчитать");

                            Console.Write("Введите первое число: ");
                            float firstNum;
                            firstNum = Convert.ToSingle(Console.ReadLine());

                            Console.Write("\n" + "Введите второе число: ");
                            float secondNum;
                            secondNum = Convert.ToSingle(Console.ReadLine());

                            switch (operationChoose)
                            {
                                case "+":
                                    Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                                    break;

                                case "-":
                                    Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                                    break;

                                case "*":
                                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                                    break;

                                case "/":
                                    Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                                    break;

                                case "%":
                                    Console.WriteLine($"Остаток от деления {firstNum} на {secondNum} равен {firstNum % secondNum}");
                                    break;
                            }

                            bool calcContinue = true; // Переменная состояния для обработки ошибки. Если пользователь вводит некорректное значение, вопрос задается повторно.
                            while (calcContinue)
                            {
                                Console.WriteLine("Желаете продолжить работать с калькулятором чисел?");
                                conditionCalc1 = Console.ReadLine().ToLower();

                                switch (conditionCalc1)
                                {
                                    case "да":
                                    case "yes":
                                    case "y":
                                    case "д":
                                        Console.WriteLine("Перенаправление в начало калькулятора");
                                        conditionCalc1 = "да";
                                        calcContinue = false;
                                        break;

                                    case "нет":
                                    case "н":
                                    case "не":
                                    case "no":
                                    case "n":
                                        Console.WriteLine("Перенаправление в начальное меню");
                                        conditionCalc1 = "нет";
                                        calcContinue = false;
                                        break;

                                    default:
                                        Console.WriteLine($"Я не знаю слова {conditionCalc1.ToUpper()}");
                                        break;
                                }

                            }
                        }
                        break;

                    case 2:

                        break;

                    case 3:

                        break;


                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    default:

                        break;
                }
            }
        }
    }
}