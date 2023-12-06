using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade47
    {
        public void atividade_47()
        {
            int tamanhoV = 10;

            int[] vetor = new int[tamanhoV];


            Console.WriteLine("Digite os números do vetor:");
            for (int i = 0; i < tamanhoV; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Digite o número X: ");
            int x = int.Parse(Console.ReadLine());


            int maior = 0, menor = 0, igual = 0;


            foreach (int numero in vetor)
            {
                if (numero > x)
                    maior++;
                else if (numero < x)
                    menor++;
                else
                    igual++;
            }

            
            Console.WriteLine("Quantidade de números maiores que X: {0}", maior);
            Console.WriteLine("Quantidade de números menores que X: {0}", menor);
            Console.WriteLine("Quantidade de números iguais a X: {0}", igual);

            Console.ReadKey();
        }
    }
}
