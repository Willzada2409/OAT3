using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade45
    {
        public void atividade_45()
        {
            Console.WriteLine("Informe o tamanho da sequencia");
            int tamanho = int.Parse(Console.ReadLine());

            int[] num = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe o número da posição {0}", i);
               num[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("A ordem inversa:");

            for (int i = tamanho - 1;  i >= 0; i--)

            {
                
                Console.WriteLine(num[i]);
            }

            Console.ReadKey();
        }
    }
}
