using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade19
    {
        public void atividade_19()
        {
            Console.WriteLine("Me informe 3 valores para os lados do triângulo");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (A < B + C && B < A + C && C < A + B) 
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if(A == B || A == C || B == C) 
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados não caracterizam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
