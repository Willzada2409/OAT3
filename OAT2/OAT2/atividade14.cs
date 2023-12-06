using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade14
    {
        public void atividade_14() 
        {
            Console.WriteLine("Me informe dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int num3 = num1 - num2;
                Console.WriteLine("A diferença do maior para o menor número é: {0}", num3);
            }
            else if (num1 < num2)
            {
                int num3 = num2 - num1;
                Console.WriteLine("A diferença do maior para o menor número é: {0}", num3);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais, ou seja, não possuem diferença");
            }
            Console.ReadKey();
        }
    }
}
