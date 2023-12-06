using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade24
    {
        public void atividade_24()
        {
            int opcao = 0;
            Console.WriteLine("Me informe dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Escolha uma das opções do menu:");
                Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: 
                        if (num1 % num2 == 0 )
                        {
                            Console.WriteLine("O número {0} é multiplo do número {1}", num1, num2);
                        }
                        else if (num2 % num1 == 0)
                        {
                            Console.WriteLine("O número {0} é multiplo do número {1}", num2, num1);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dos números são multiplos entre sí");
                        }
                        break;

                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Ambos os números são par");
                        }
                        else if (num1 % 2 == 0 || num2 % 2 == 0)
                        {
                            Console.WriteLine("Um dos números é par");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dos números é par");
                        }
                        break;

                    case 3:
                        double media = (num1 + num2) / 2;
                        
                        if (media >= 7)
                        {
                            Console.WriteLine("A média dos dois números é maior ou igual a 7, média igual a {0}", media);
                        }
                        else
                        {
                            Console.WriteLine("A média dos números é menor que 7");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Menu será encerrado, até logo.");

                        break;

                    default:
                        Console.WriteLine("Opção escolhida não existe no menu");
                        break;
                }




            } while (opcao != 4);
        }
    }
}
