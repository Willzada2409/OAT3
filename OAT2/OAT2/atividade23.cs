using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade23
    {
        public void atividade_23()
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("");

            int operacao = int.Parse(Console.ReadLine());


            while (operacao < 1 || operacao > 4) 
            {
                Console.WriteLine("Opção inválida, escolha novamente");
                operacao = int.Parse(Console.ReadLine());
            }

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Informe dois números");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    int adicao = num1 + num2;

                    Console.WriteLine("O resultado é {0}", adicao);

                    break;

                case 2:
                    Console.WriteLine("Informe dois números");
                    int num3 = int.Parse(Console.ReadLine());
                    int num4 = int.Parse(Console.ReadLine());

                    int sub = num3 - num4;

                    Console.WriteLine("O resultado é {0}", sub);

                    break;

                case 3:
                    Console.WriteLine("Informe dois números");
                    int num5 = int.Parse(Console.ReadLine());
                    int num6 = int.Parse(Console.ReadLine());

                    int mult = num5 * num6;

                    Console.WriteLine("O resultado é {0}", mult);

                    break;

                case 4:
                    Console.WriteLine("Informe dois números");
                    double num7 = double.Parse(Console.ReadLine());
                    double num8 = double.Parse(Console.ReadLine());

                    double div = num7 / num8;

                    Console.WriteLine("O resultado é {0}", div);

                    break;
            }
            Console.ReadKey();
        }
    }
}
