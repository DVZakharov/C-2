using System;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон от 1 до n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во попыток");
            int k = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int rndnum = rnd.Next(1, n+1); 
            
            Console.WriteLine("Угадайте число");
            int attepts = 0;
            bool win = false;
            while (attepts < k)
            {
                int ps = Convert.ToInt32(Console.ReadLine());
                if (rndnum == ps)
                {
                    Console.WriteLine("Вы угадали");
                    win = true;
                    break;
                }
                if (rndnum > ps)
                    Console.WriteLine($"Загаданное число больше {ps}");
                if (rndnum < ps)
                    Console.WriteLine($"Загаданное число меньше {ps}");
                attepts += 1;
                if (k - attepts == 1) 
                    Console.WriteLine("Осталась одна попытка");
            } 
            if (!win)
                Console.WriteLine("Вы не угадали");
        }
    }
}