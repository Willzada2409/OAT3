using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade22
    {
        public void atividade_22()
        {
            Console.WriteLine("Informe um número");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                int A = num;
                Console.WriteLine("O número positivo armazenado em A foi: {0}", A);
            }
            else if (num < 0)
            {
                int B = num;
                Console.WriteLine("O número negativo armazenado em B foi: {0}", B);
            }
            else
            {
                Console.WriteLine("Você digitou o número 0");
            }
            Console.ReadKey();
        }
    }
}
