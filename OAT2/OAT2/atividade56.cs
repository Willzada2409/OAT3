using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade56
    {
        public void atividade_56()
        {
            int tamanho = 50;
            int[] num = new int[tamanho];
            
            for (int i = 0; i < tamanho; i++) 
            {
                Console.WriteLine("Me informe o número positivo da posição {0}", i + 1);
                num[i] = int.Parse(Console.ReadLine());

                while (num[i] < 0)
                {
                    Console.WriteLine("Só são permitidos números positivos");
                    num[i] = int.Parse(Console.ReadLine());
                }
            }

            int par = 0;
            int mult = 0;

            for (int i = 0;i < tamanho;i++)
            {
                if (num[i] % 2 == 0)
                {
                    par++;
                }
                if (num[i] % 5 == 0)
                {
                    mult++;
                }
            }

            Console.WriteLine("Saiu um total de {0} número(s) par(es)", par);
            Console.WriteLine("{0} número(s) são multiplos de 5.", mult);

            Console.ReadKey();
        
        }
    }
}
