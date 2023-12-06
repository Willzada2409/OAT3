using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade39
    {
        public void atividade_39()
        {
            while (true)
            {



                Console.WriteLine("Me informe um número:");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O número informado é par");
                }
                else
                {
                    Console.WriteLine("O número informado é ímpar");
                }

                if (num >= 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else
                {
                    Console.WriteLine("O número é negativo");
                }

                Console.WriteLine("Deseja encerrar o programa ? (S / N) ");
                string resposta = Console.ReadLine();

                if (resposta == "S")
                {
                    break;
                }
            }
            
        }
    }
}
