using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me diga seu nome e sua idade!");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine(nome + ", você não pode beber!!!");
            } else
            {
                if (idade > 200)
                {
                    Console.WriteLine("Você já é uma múmia!!!");
                } else
                {
                    Console.WriteLine("Parabéns " + nome + ", pode encher a cara!!!");
                }
            }
        }
    }
}
