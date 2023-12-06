using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade12
    {
        public void atividade_12()
        {
            Console.WriteLine("Me informa um número");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine("O módulo do número é: {0}", num1);
            }
            else
            {
                num1 = num1 * (-1);
                Console.WriteLine("O módulo do número é: {0}", num1);
            }
            Console.ReadKey();
        }
    }
}
