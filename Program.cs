using System;
using System.Collections.Generic;

namespace Обратная_польская_запись
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;// для расчета количества переменных
            int v = 0;// для расчета количества операндов
            float c;// для расчета результата действия и далее конечного результата
            string s;// вписываем строку
            int variable;
            var list = new List<int>();
            Console.WriteLine("Впишите строку Обратной Польской Записи с пробелами");
            s = Console.ReadLine();
            string[] subs = s.Split(' ');
            foreach (var sub in subs) // создадим список из преременных
            {
                bool result = int.TryParse(sub, out variable); // условие на переменную
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

            int k = n; 

            for (int i = n; i <= n+(v-1); i++)
            {
                switch (subs[i])
                {
                    case "+":
                        Console.WriteLine("Наш операнд:"+subs[i]);
                        int a = list[k-2];
                        int b = list[k-1];
                        c = a + b;
                        //list[k - 2] = (int)c;
                        list.Insert(k -2,(int)c);
                        list.RemoveAt(k - 1);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        k--;
                        break;
                    case "-":
                        Console.WriteLine("Наш операнд:" + subs[i]);
                        a = list[k-2];
                        b = list[k-1];
                        c = a - b;
                        //list[k - 2] = (int)c;
                        list.Insert(k - 2, (int)c);
                        list.RemoveAt(k-1);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        k--;
                        break;
                    case "*":
                        Console.WriteLine("Наш операнд:" + subs[i]);
                        a = list[k - 2];
                        Console.WriteLine(a);
                        b = list[k-1];
                        Console.WriteLine(b);
                        c = a * b;
                        //list[k - 2] = (int)c;
                        list.Insert(k - 2, (int)c);
                        list.RemoveAt(k-1);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        k--;
                        break;
                    case "/":
                        Console.WriteLine("Наш операнд:" + subs[i]);
                        a = list[k-2];
                        b = list[k-1];
                        c = a / b;
                        //list[k - 2] = (int)c;
                        list.Insert(k - 2, (int)c);
                        list.RemoveAt(k - 1);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        k--;
                        break;
                    case "^":
                        Console.WriteLine("Наш операнд:" + subs[i]);
                        a = list[k-2];
                        b = list[k-1];
                        c = a ^ b;
                        //list[k - 2] = (int)c;
                        list.Insert(k - 2, (int)c);
                        list.RemoveAt(k - 1);
                        Console.WriteLine("Вычисленное выражение равно " + c);
                        k--;
                        break;
                }

            }
        }
    }
}

