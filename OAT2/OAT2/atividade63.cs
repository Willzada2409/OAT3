using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade63
    {
        public void atividade_63()
        {
            Console.WriteLine("Me informe um número");
            int num = int.Parse(Console.ReadLine());

            string result = Verifica(num);

            Console.WriteLine("O número {0} é {1}", num, result);

            Console.ReadKey();
        }

        public string Verifica(int num)
        {
            if (num % 2 == 0)
            {
                return "PAR";

            }
            else
                return "IMPAR";
        }
    }
}
