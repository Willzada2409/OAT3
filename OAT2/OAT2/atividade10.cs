using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade10
    {
        public void atividade_10()
        {
            Console.WriteLine("Me informe dois números ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (num1 > num2 && num1 != num2) 
            {
                Console.WriteLine("O {0} é maior que o {1}", num1, num2);
                Console.WriteLine("O {0} é menor que o {1}", num2, num1);
                Console.WriteLine("O {0} é maior ou igual a {1}", num1, num2);
                Console.WriteLine("O {0} é menor ou igual a {1}",num2, num1);
                Console.WriteLine("Os números não são iguais");

            }
            else if (num1 < num2 && num1 != num2)
            {
                Console.WriteLine("O {0} é maior que o {1}", num2, num1);
                Console.WriteLine("O {0} é menor que o {1}", num1, num2);
                Console.WriteLine("O {0} é maior ou igual a {1}", num2, num1);
                Console.WriteLine("O {0} é menor ou igual a {1}", num1, num2);
                Console.WriteLine("Os números não são iguais");
            }
            
            
                Console.ReadKey();
            
        }
    }
}
