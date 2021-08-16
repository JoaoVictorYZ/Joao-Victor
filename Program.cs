using System;

namespace Joao_Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade?"); // Pergunta a idade do usuário
            var userAge = int.Parse(Console.ReadLine()); // Salva a idade do usuário na variavel: userAge
            // string texto = "";
            // int inteiro = 0;
            // double decimais = 0.0;
            if (userAge > 18)
            {
                Console.WriteLine("Maior de 18");
            }

            // else if (userAge == 18)
            // {
            //     Console.WriteLine("Igual a 18");
            // }

            // else
            // {
            //     Console.WriteLine("Menor de 18");
            // }

            while (userAge > 18)
            {
                Console.WriteLine("loop infinito porquê userAge sempre será maior que 18");
            }
        }
    }  
}