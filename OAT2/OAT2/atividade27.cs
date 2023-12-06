using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade27
    {
        public void atividade_27()
        {
            Console.Write("Digite a quantidade de números a serem processados: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
                }
                else
                {
                    long resultado = 1;

                    for (int j = 1; j <= numero; j++)
                    {
                        resultado *= j;
                    }

                    Console.WriteLine($"O fatorial de {numero} é: {resultado}");
                }
            }
        }
    }
}
