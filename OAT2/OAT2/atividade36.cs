using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade36
    {
        public void atividade_36()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            double media = 0;
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe 10 números positivos");
                 int num = int.Parse(Console.ReadLine());

                while (num < 0)
                {
                    Console.WriteLine("Número negativo encontrado, informe novamente");
                    num = int.Parse(Console.ReadLine());
                }

                if (num < menor)
                {
                    menor = num;
                }
                else if (num > maior)
                {
                    maior = num;
                }
                total += num;
               
                media = total / 10;

                
            }


            if (menor != int.MaxValue && maior != int.MinValue)
            {
                Console.WriteLine("O maior número digitado foi: {0}", maior);
                Console.WriteLine("O menor número digitado foi: {0}", menor);
                Console.WriteLine("A média dos números é: {0}", media);
            }  
            
            Console.ReadKey();
        }
    }
}
