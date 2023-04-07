using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            string input = Console.ReadLine();
            try
            {
                double result = Calculate(input);
                Console.WriteLine("Результат: {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: {0}", e.Message);
            }
        }

        static double Calculate(string input)
        {
            // Разбиваем входную строку на токены (числа и операторы)
            List<string> tokens = new List<string>();
            string number = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(c.ToString());
                }
                else
                {
                    throw new ArgumentException("Недопустимый символ: " + c);
                }
            }
            if (number != "")
            {
                tokens.Add(number);
            }

            // Вычисляем значение выражения с учетом приоритета операций
            Stack<double> values = new Stack<double>();
            Stack<char> operators = new Stack<char>();
            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double value))
                {
                    values.Push(value);
                }
                else
                {
                    char op = token[0];
                    while (operators.Count > 0 && HasHigherPrecedence(operators.Peek(), op))
                    {
                        ApplyOperation(values, operators.Pop());
                    }
                    operators.Push(op);
                }
            }
            while (operators.Count > 0)
            {
                ApplyOperation(values, operators.Pop());
            }
            return values.Pop();
        }

        static bool HasHigherPrecedence(char op1, char op2)
        {
            // Возвращает true, если op1 имеет более высокий или равный приоритет, чем op2
            if (op1 == '*' || op1 == '/')
            {
                return true;
            }
            if (op1 == '+' || op1 == '-')
            {
                return op2 == '+' || op2 == '-';
            }
            return false;
        }

        static void ApplyOperation(Stack<double> values, char op)
        {
            // Применяет операцию к двум верхним элементам стека значений и заменяет их результатом
            if (values.Count < 2)
            {
                throw new ArgumentException("Недостаточно операндов для операции: " + op);
            }
            double right = values.Pop();
            double left = values.Pop();
            double result = 0;
            switch (op)
            {
                case '+':
                    result = left + right;
                    break;
                case '-':
                    result = left - right;
                    break;
                case '*':
                    result = left * right;
                    break;
                case '/':
                    if (right == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = left / right;
                    break;
                default:
                    throw new ArgumentException("Недопустимая операция: " + op);
            }
            values.Push(result);
        }
    }
}
