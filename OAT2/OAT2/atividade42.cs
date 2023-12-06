using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade42
    {
        public void atividade_42()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int num = 0;
            

            

            do
            {
                Console.WriteLine("Informe os números (Digite 0 para encerrar e ver o maior e o menor número informado)");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    else if (num < menor)
                    {
                        menor = num;
                    }
                }

            } while (num != 0);

           
            if (maior != int.MinValue && menor != int.MaxValue)
            {

                Console.WriteLine("O maior número digitado foi: {0}", maior);
                Console.WriteLine("O menor número digitado foi: {0}", menor);
            }
            Console.ReadKey();
        }
    }
}
