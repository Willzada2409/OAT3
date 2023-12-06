using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade40
    {
        public void atividade_40()
        {
            string resposta = "S";

            do
            {
                Console.WriteLine("Me informa o índice de poluição:");
                double indice = double.Parse(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Índice de poluição está aceitável");
                }
                else if (indice > 0.25 && indice <= 0.3)
                {
                    Console.WriteLine("Industrias do 1º grupo devem suspender suas atividade");
                }
                else if (indice > 0.3 && indice <= 0.4)
                {
                    Console.WriteLine("Industrias do 2º grupo devem suspender suas atividade");
                }
                else if (indice > 0.4 && indice <= 0.5)
                {
                    Console.WriteLine("Industrias de todos os grupos devem suspender suas atividade");
                }
                else if (indice > 0.5)
                {
                    Console.WriteLine("Índice muito elevado, deve parar completamente as atividade");
                }
                else
                {
                    Console.WriteLine("Indice não é válido");
                }

                Console.WriteLine("Deseja encerrar o programa ? (S ou N)");
                resposta = Console.ReadLine();

            }while (resposta != "S");
        }
    }
}
