using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade32
    {
        public void atividade_32()
        {
            Console.WriteLine("Digite um número entre 1 e 9");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num < 10)
            {
                int contador = 0;
                int somaQ = 0;

                for (int i = num; contador < 20; i++)
                {
                    if (i % 2 != 0)
                    {
                        somaQ += i * i;
                        contador++;
                    }
                }
                Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de {0} é: {1}", num, somaQ);             
            }
            else
            {
                Console.WriteLine("O número digitado não está dentro do intervalo válido.");
            }
            Console.ReadKey();
        }
    }
}
