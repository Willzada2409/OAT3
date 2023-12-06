using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade13
    {
        public void atividade_13() 
        {
            Console.WriteLine("Informe 3 números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3 && num2 < num3)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num3, num2, num1);
            }
            else if (num2 < num1 && num2 < num3 && num3 < num1)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num1, num3, num2);
            }
            else if (num3 < num1 && num3 < num2 && num1 < num2)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num2, num1, num3);
            }
            else if (num1 < num2 && num1 < num3 && num3 < num2)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num2, num3, num1);
            }
            else if (num2 < num1 && num2 < num3 && num1 < num3)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num3, num1, num2);
            }
            else if (num3 < num1 && num3 < num2 && num2 < num1)
            {
                Console.WriteLine("A ordem decrescente dos números é: {0}, {1}, {2}", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("Os números são todos iguais");
            }
            Console.ReadKey();
        }
    }
}
