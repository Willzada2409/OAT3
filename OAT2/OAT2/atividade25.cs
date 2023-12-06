using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade25
    {
        public void atividade_25()
        {
            double pesoIdeal = 0;
            Console.WriteLine("Me informe seu sexo F (feminino) e M (masculino)");
            string sexo = Console.ReadLine();
            Console.WriteLine("Me informe sua altura (em metros)");
            double altura = double.Parse(Console.ReadLine());

            while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F")
            {
                Console.WriteLine("sexo inexistente, informe um sexo válido e a altura novamente");
                sexo = (Console.ReadLine());
                altura = double.Parse(Console.ReadLine());
            }
                if (sexo == "M" || sexo == "m")
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    Console.WriteLine("Seu peso ideial é {0}", pesoIdeal);
                }
                else if (sexo == "F" || sexo == "f")
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine("Seu peso ideial é {0}", pesoIdeal);
                }

            
            Console.ReadKey();
        }
    }
}
