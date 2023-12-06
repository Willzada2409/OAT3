using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade35
    {
        public void atividade_35()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                {
                    Console.WriteLine("{0} é multipro de 10", i);
                }
            }
            Console.ReadKey();
        }
    }
}

