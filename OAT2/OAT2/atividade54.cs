using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade54
    {
        public void atividade_54()
        {
            int[] A = new int[5];
            int[] B = new int[8];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Digite os números do primeiro vetor");
                A[i] = int.Parse(Console.ReadLine());
            
            }

            for (int i = 0;i < 8;i++)
            {
                Console.WriteLine("Digite os números do sgundo vetor");
                B[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Esses são os elementos em comum dos dois vetores");

            foreach (int elementoA in A)
            {
                foreach (int elementoB in B)
                {
                    if (elementoA == elementoB)
                    {
                        Console.WriteLine(elementoA + "");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
