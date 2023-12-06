using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade49
    {
        public void atividade_49()
        {
            int maximo = 50;

            Console.WriteLine("Me informe o tamanho dos vetores (no máximo 50)");
            int tamanho = int.Parse(Console.ReadLine());

            while (tamanho > maximo)
            {
                Console.WriteLine("Ultrapassou o tamanho máximo permitido, informe o tamanho novamente");
                tamanho = (int.Parse(Console.ReadLine()));
            }



            int[] V1 = new int[tamanho];
            int[] V2 = new int[tamanho];

            Console.WriteLine("Informe os valores do primeiro Vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Número {0}", i + 1);
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe os valores do segundo Vetor");
            for (int i = 0;i < tamanho; i++)
            {
                Console.WriteLine("Número {0}", i + 1);
                V2[i] = int.Parse(Console.ReadLine());
            }

            int iguais = 0;

            for (int i = 0; i < tamanho;i++)
            {
                if (V1[i] == V2[i])
                {
                    iguais++;
                }
            }

            Console.WriteLine("A quantidade de vezes que apareceram valores identicos na mesma posição foi: {0}", iguais);

            Console.ReadKey();

        }
    }
}
