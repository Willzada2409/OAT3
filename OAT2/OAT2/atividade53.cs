using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade53
    {
        public void atividade_53()
        {
            Console.WriteLine("Irforme quantas voltas tem a corrida");
            int tamanho = int.Parse(Console.ReadLine());

            double[] voltas = new double[tamanho];
            double melhor = double.MaxValue;
            int melhorVolta = 0;
            double soma = 0;
            
            
            
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Me informe o tempo da volta {0}", i + 1);
                voltas[i] = double.Parse(Console.ReadLine());

                if (voltas[i] < melhor)
                {
                    melhor = voltas[i];
                    melhorVolta = i + 1;
                }
                soma += voltas[i];
            }

            double media = soma / tamanho;

            Console.WriteLine("O melhor tempo entre todas as voltas foi: {0}", melhor);
            Console.WriteLine("A volta do melhor tempo, foi a volta: {0}", melhorVolta);
            Console.WriteLine("O tempo médio das voltas foi: {0}", media);
           
            Console.ReadKey();
        }
    }
}
