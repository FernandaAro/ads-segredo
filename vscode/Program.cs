using System;

namespace segredo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random randNum = new Random();
            int sorteio = randNum.Next(10);

            int usuario;
            int tentativas = 5;

            Console.WriteLine("Você tem 5 tentativas para adivinhar o número secreto...");

            while (tentativas > 0)
            {
                Console.WriteLine("Digite um número: ");
                usuario = int.Parse(Console.ReadLine());

                if (usuario == sorteio)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opss... Você errou...");
                }
                tentativas = tentativas - 1;
            }
            Console.WriteLine("O número secreto era... " + sorteio);
        }
    }
}
