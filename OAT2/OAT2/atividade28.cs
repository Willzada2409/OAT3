using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade28
    {
        public void atividade_28()
        {
            Console.WriteLine("Os números ímpares são:");
            for (int i = 100; i <= 200; i ++)
            {
               
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
