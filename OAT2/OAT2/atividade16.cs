using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade16
    {
        public void atividade_16()
        {
            Console.WriteLine("Me informe dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("O numéro {0} é o maior e o número {1} é o menor", num1, num2);
            }
            else if (num2 > num1) 
            {
                Console.WriteLine("O numéro {0} é o maior e o número {1} é o menor", num2, num1);
            }
            Console.ReadKey();
        }
    }
}
