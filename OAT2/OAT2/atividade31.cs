using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade31
    {
        public void atividade_31()
        {
            Console.WriteLine("Digite um conjunto de números positivos. Digite um número negativo para encerrar e ver o resultado da soma dos números Pares e Impares:");

            int num = 0;
            int somaP = 0;
            int somaI = 0;

            do
            {

                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());


                if (num >= 0)
                {

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("{0} é par", num);
                        somaP += num;
                    }
                    else
                    {
                        Console.WriteLine("{0} é ímpar", num);
                        somaI += num;
                    }
                }
                else
                {
                    Console.WriteLine("Número negativo detectado. Encerrando a leitura.");
                }

            } while (num >= 0);


            Console.WriteLine("Soma dos números pares: {0}", somaP);
            Console.WriteLine("Soma dos números ímpares: {0}", somaI);
            Console.ReadKey();
        }
    }
}
