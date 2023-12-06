using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade58
    {
        public void atividade_58()
        {
            Console.WriteLine("Quantos números positivos serão lidos ?");
            int tamanho = int.Parse(Console.ReadLine());

            int[] num = new int[tamanho];
            int soma = 0;
            int maior = int.MinValue;

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe o número da posição {0}", i + 1);
                num[i] = int.Parse(Console.ReadLine());

                while (num[i] < 0)
                {
                    Console.WriteLine("Só são permitidos números positivos, informe novamente");
                    num[i] = int.Parse(Console.ReadLine());
                }

                soma += num[i];
            }

            double media = soma / tamanho;

            for (int i = 0;i < tamanho; i++)
            {
                if (num[i] > maior)
                {
                    maior = num[i];
                }
            }

            Console.WriteLine("A média dos valores informado é: {0}", media);
            Console.WriteLine("O maior valor informado foi: {0}", maior);

            Console.ReadKey();
        }
    }
}
