using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade43
    {
        public void atividade_43()
        {
            int numQ = 64;
            ulong total = 0;

            for (int i = 1;  i <= numQ; i++)
            {
                ulong graos = (ulong)Math.Pow(2, i -1);

                total += graos;

                Console.WriteLine("O quadro {0}, tem {1} grãos", i, graos);
            }

            Console.WriteLine("O total de grãos que ele esperava receber é: {0}", total);

            Console.ReadKey();
        }
    }
}
