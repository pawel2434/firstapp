using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //pętla for wykonuje to co w klamrach od 0-9 (10x), krok ++ to co 1
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }

            //blokuje ekran do czasu az wciśniesz guzik
            Console.ReadKey();
        }
    }
}
