using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace jogo_campo_minado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;              //jogador
            int a2;                 //nm jogadores
            double b = 1, c = 100;  //nm min/max
            double d;              //chute

            Random rand = new Random();
            int num = rand.Next(1, 101);

            Console.WriteLine(num);

            Console.Write("Digite o Nº de jogadores:");
            a2 = int.Parse(Console.ReadLine());
            a2 = a2 + 1;
            string[] r = new string[a2];
            Console.Clear();

            for (int i = 1; i < a2; i++)
            {
                Console.Write($"Nome do {i}° jogador:");
                r[i] = Console.ReadLine();
            }
            Console.Clear();

            do
            {
                do
                {
                    Console.Write($"{r[a]}, digite um Nº entre {b} e {c}:");
                    d = double.Parse(Console.ReadLine());
                } while (d < b && d > c);

                if (d > b && d < c)
                {
                    if (d > num && d < c) c = d;
                    if (d < num && d > b) b = d;
                    if (a == a2) a = 1;
                    a++;
                    Console.Clear();
                }
            } while (d != num);

            if(d == num)
            {
                a--;
                Console.WriteLine($"{r[a]} perdeu o jogo. XD");
            }
        }
    }
}
