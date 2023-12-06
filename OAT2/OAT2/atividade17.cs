using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade17
    {
        public void atividade_17()
        {
            Console.WriteLine("Me informe um número");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            Console.ReadKey();
        }
    }
}
