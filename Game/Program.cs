using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Number number = new Number();
        number.Set();
        Console.Write(number.Get());
        number.Help();
        

    }
    public class Number
    {
        private int n;
        private int x1;
        private int x3;


        public void Set()
        {
            Random rnd = new Random();
             n = rnd.Next(100);
        }

        public int Get()
        {
            return n;
        }

        public void diaposon(int n,int x1)
        {

            int lowpoli = (x1 / 10) * 10;
            int hightpoli = lowpoli + 10;

            // Обрабатываем ситуацию, когда загаданное число совпадает с предполагаемым
            if (n == x1)
            {
                Console.WriteLine($"Вы угадали число!");
                Console.WriteLine($"Загаданое число было {n}");
            }
            else
            {
                // Выводим подсказку
                Console.WriteLine($"Число находится в промежутке от {lowpoli} до {hightpoli}");

                // Проверяем, в каком промежутке находится загаданное число
                if (n >= lowpoli && n < hightpoli)
                {
                    Console.WriteLine($"Подсказка: число находится в промежутке от {lowpoli} до {hightpoli}");
                }
                else
                {
                    // Загаданное число не совпадает с предполагаемым и не находится в предполагаемом промежутке
                    Console.WriteLine("Число находится за пределами предполагаемого промежутка");
                }
            }
        }
        public void сhetornot(int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine($"Число четное\n");
            }
            else
            {
                Console.WriteLine($"Число нечетное\n");
            }
        }
        public void Help()
        {
            do
            {
                int b = 100;
                Console.WriteLine($"Баланс = {b}\n");
                Console.WriteLine($"Введите Предпологаемое Число\n");
                string? x = Console.ReadLine();
                x1 = Convert.ToInt32(x);
                if (x1!=n)
                {
                    Console.WriteLine($"Вы не угадали число!");
                }
                else
                {
                    Console.WriteLine($"Вы угадали число!");
                }
                Console.WriteLine($"Напишите на цифру 1-9 для получения подсказки о числе\n" +
                    $"1)подсказка о диапозоне, где стоит число(10 очков)\n" +
                    $"2)Подсказка о том, число четное или нет(20 очков)\n");
                string ? x2 = Console.ReadLine();
                x3 = Convert.ToInt32(x2);
                switch(x3)
                {
                    case 1:
                    diaposon(n,x1);
                        b = b - 10;
                        Console.WriteLine($"Баланс = {b}\n");
                        continue;
                    case 2:
                        сhetornot(n);
                        b = b - 20;
                        Console.WriteLine($"Баланс = {b}\n");
                        break;

                }

                
            }
            while (n != x1);
           

            
          
        }
        

        public void toString()
        {
            Console.WriteLine(this.ToString());
        }



    }
}
