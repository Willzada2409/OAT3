using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade34
    {
        public void atividade_34()
        {
            Console.WriteLine("Digite um conjunto de números positivos. Digite um número negativo para encerrar e ver o maior e o menor número do conjunto:");

            int maior = int.MinValue;
            int menor = int.MaxValue;

            while (true)
            {
                Console.WriteLine("Me informe o número:");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    break;
                }

                if (num < menor)
                {
                    menor = num;
                }
                else if (num > maior)
                {
                    maior = num;
                }
            }
            if (menor != int.MaxValue &&  maior != int.MinValue)
            {
                Console.WriteLine("O maior número digitado foi: {0}", maior);
                Console.WriteLine("O menor número digitado foi: {0}", menor);
            }
            Console.ReadKey();
        }
    }
}
