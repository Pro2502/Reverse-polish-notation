using System;
using System.Collections.Generic;

namespace Обратная_польская_запись
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            float c;
            string s;
            var list = new List<int>();
            Console.WriteLine("Впишите строку Обратной польской записи с пробелами");
            s = Console.ReadLine();
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {
                Console.WriteLine(n+$"-й операнд:{sub}");
                try
                {
                    int j = Convert.ToInt32(sub);
                    list.Add(n);
                }
                catch (Exception)
                {
                    switch (sub)
                    {
                        case "+":
                            int a = list[n - 1];
                            int b = list[n];
                            c = a + b;
                            list.Remove(a);
                            list.Remove(b);
                            Console.WriteLine("Вычисленное выражение равно " + c);
                            break;
                        case "-":
                             a = list[n - 1];
                             b = list[n];
                             c = a - b;
                            list.Remove(a);
                            list.Remove(b);
                            Console.WriteLine("Вычисленное выражение равно " + c);
                            break;
                        case "*":
                             a = list[n - 1];
                             b = list[n];
                            c = a * b;
                            list.Remove(a);
                            list.Remove(b);
                            Console.WriteLine("Вычисленное выражение равно " + c);
                            break;
                        case "/":
                             b = list[n - 1];
                             a = list[n];
                            c = a / b;
                            list.Remove(a);
                            list.Remove(b);
                            Console.WriteLine("Вычисленное выражение равно " + c);
                            break;
                        case "^":
                             b = list[n - 1];
                             a = list[n];
                            c = a ^ b;
                            list.Remove(a);
                            list.Remove(b);
                            Console.WriteLine("Вычисленное выражение равно " + c);
                            break;
                    }
                }
                n++;
            }
            
        }
    }
}
