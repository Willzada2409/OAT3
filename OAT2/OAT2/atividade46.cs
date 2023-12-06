using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade46
    {
        public void atividade_46()
        {
            Console.WriteLine("Me informe qual vai ser o tamanho dos vetores");
            int tamanho = int.Parse(Console.ReadLine());
            
            int[] x = new int[tamanho];
            int[] y = new int[tamanho];

            Console.WriteLine("Digite os números do Vetor X");

            for (int i = 0; i < tamanho; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os números do Vetor Y");

            for (int i = 0; i < tamanho; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }


            int produto = 0;    

            for (int i = 0;i < tamanho; i++)
            {
                produto += x[i] * y[i];
            }

            Console.WriteLine("O produto escalar dos vetores é: {0}", produto);

            Console.ReadKey();
        }
    }
}
