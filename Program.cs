using System;
using System.Collections.Generic;

namespace Обратная_польская_запись
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int v = 0;
            float c;
            string s;
            int variable;
            var list = new List<int>();
            Console.WriteLine("Впишите строку Обратной польской записи с пробелами");
            s = Console.ReadLine();
            string[] subs = s.Split(' ');
            foreach (var sub in subs)
            {
                bool result = int.TryParse(sub, out variable);
                if (result)
                {
                    int j = Convert.ToInt32(sub);
                    list.Add(n);
                    Console.WriteLine(n + $"-я переменная:{sub}");
                    n++;
                }
            }
            Console.WriteLine("Количество переменных в списке, начиная с '0' = " + n);

            foreach (var sub in subs)
            {
                
                bool result = int.TryParse(sub, out variable);
                if (result == false)
                {
                    Console.WriteLine(v + $"-й операнд: {sub}");
                    v++;
                }  
            }
            Console.WriteLine("Количество операндов, начиная с '0' = " + v);
            for (int i = v-1; i >= 0; i--)
            {
                switch (subs[i])
                {
                    case "+":
                        int a = list[1];
                        int b = list[0];
                        c = a + b;
                        list.RemoveAt(1);
                        list[0] = (int)c;
                        //list.Insert(0,(int)c);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        break;
                    case "-":
                        a = list[1];
                        b = list[0];
                        c = a - b;
                        list.RemoveAt(1);
                        list[0] = (int)c;
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        break;
                    case "*":
                        a = list[1];
                        b = list[0];
                        c = a * b;
                        list.RemoveAt(1);
                        list[0] = (int)c;
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        break;
                    case "/":
                        b = list[1];
                        a = list[0];
                        c = a / b;
                        list.RemoveAt(1);
                        list[0] = (int)c;
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        break;
                    case "^":
                        b = list[1];
                        a = list[0];
                        c = a ^ b;
                        list.RemoveAt(1);
                        list[0] = (int)c;
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        break;
                }

            }
        }
    }
}

