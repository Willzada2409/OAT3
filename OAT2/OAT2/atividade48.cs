using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade48
    {
        public void atividade_48()
        {
            int tamanho = 20;
            string[] nome = new string[tamanho];
            int[] idade = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Me informe o nome da candidata {0}", i + 1);
                nome[i] = Console.ReadLine();

                Console.WriteLine("Me informe a idade da candidata {0}", i + 1);
                idade[i] = int.Parse(Console.ReadLine());

                
            }

            for (int i = 0; i < tamanho; i++)
            { 

                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine("Canditada {0} possui {1} anos, está aprovada", nome[i], idade[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
