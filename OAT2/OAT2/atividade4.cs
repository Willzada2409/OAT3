using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade4
    {
        public void atividade_4()
        {
            Console.WriteLine("Me informe 4 valores númericos inteiros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int soma1 = num1 + num2;
            int soma2 = num1 + num3;
            int soma3 = num1 + num4;
            int soma4 = num2 + num3;
            int soma5 = num2 + num4;
            int soma6 = num3 + num4;

            int mult1 = num1 * num2;
            int mult2 = num1 * num3;
            int mult3 = num1 * num4;
            int mult4 = num2 * num3;
            int mult5 = num2 * num4;
            int mult6 = num3 * num4;

            Console.WriteLine("O resultado da soma entre {0} e {1} é {2}, e a soma entre {3} e {4} é {5}", num1, num2, soma1, num1, num3, soma2);
            Console.WriteLine("");
            Console.WriteLine("O resultado da soma entre {0} e {1} é {2}, e a soma entre {3} e {4} é {5}", num1, num4, soma3, num2, num3, soma4);
            Console.WriteLine("");
            Console.WriteLine("O resultado da soma entre {0} e {1} é {2}, e a soma entre {3} e {4} é {5}", num2, num4, soma5, num3, num4, soma6);
            Console.WriteLine("");
            Console.WriteLine("O resultado da multiplicação entre {0} e {1} é {2}, e a multiplicação entre {3} e {4} é {5}", num1, num2, mult1, num1, num3, mult2);
            Console.WriteLine("");
            Console.WriteLine("O resultado da multiplicação entre {0} e {1} é {2}, e a multiplicação entre {3} e {4} é {5}", num1, num4, mult3, num2, num3, mult4);
            Console.WriteLine("");
            Console.WriteLine("O resultado da multiplicação entre {0} e {1} é {2}, e a multiplicação entre {3} e {4} é {5}", num2, num4, mult5, num3, num4, mult6);

            Console.ReadKey();
        }
    }
}
