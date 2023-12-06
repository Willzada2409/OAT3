using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade59
    {
        public void atividade_59()
        {
            Console.Write("Digite 2 caracteres de A a Z em ordem alfabética: ");
            char carac1 = char.Parse(Console.ReadLine());
            char carac2 = char.Parse(Console.ReadLine());

            
            if (carac1 >= 'A' && carac1 <= 'Z' && carac2 >= 'A' && carac2 <= 'Z' && carac1 <= carac2)
            {
                
                int numCarac = carac2 - carac1 - 1;

                Console.WriteLine("O número de caracteres entre {0} e {1} é: {2}", carac1, carac2, numCarac);
            }
            else
            {
                
                Console.WriteLine("Erro: Os caracteres não estão em ordem alfabética. Informe novamente");
                carac1 = char.Parse(Console.ReadLine());
                carac2 = char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
