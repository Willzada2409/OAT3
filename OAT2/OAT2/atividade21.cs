using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade21
    {
        public void atividade_21()
        {
            int validador = 0;
            do
            {
                Console.WriteLine("Me informe um número");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("O número informado é positivo");
                }
                else
                {
                    Console.WriteLine("O número informado é negativo");
                }


                

                Console.WriteLine("Deseja conitunuar rodando o código ? Digite 0 para 'SIM' e -1 para 'NÃO'");
                validador = int.Parse(Console.ReadLine());

                



            } while (validador != -1);
            
        }
    }
}
