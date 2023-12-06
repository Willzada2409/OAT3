using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade50
    {
        public void atividade_50()
        {
            Random random = new Random();

            int numSorteado = random.Next(0, 100);
            int palpite = 0;
            int numTentativa = 0;

            Console.WriteLine("Vamos jogar um joguinho de adivinhação");
            do
            {
                Console.WriteLine("Tente acertar o número sorteado (Entre 0 e 100)");
                palpite = int.Parse(Console.ReadLine());

                numTentativa++;

                if (palpite == numSorteado)
                {
                    Console.WriteLine("Parabéns você acertou o número, em {0} tentativas", numTentativa);
                }
                else if (palpite > numSorteado)
                {
                    Console.WriteLine("Errooouu, tente um número menor");
                }
                else
                {
                    Console.WriteLine("Errooouu, tente um número maior");
                }

            } while (numSorteado != palpite);
            
            Console.ReadKey();
        }
    }
}
