using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade37
    {
        public void atividade_37()
        {

            string escolha = "";
            do
            {

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("Informe a opção:");

                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe dois números:");
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                double result = 0;
                switch (opcao)
                {
                    case 1:
                        result = num + num2;
                        Console.WriteLine("A soma dos números é: {0}", result);

                        break;


                    case 2:
                        result = num - num2;
                        Console.WriteLine("A subtração dos números é: {0}", result);

                        break;

                    case 3:
                        result = num * num2;
                        Console.WriteLine("A multiplicação dos números é: {0}", result);

                        break;

                    case 4:
                        result = num / num2;
                        Console.WriteLine("A subtração dos números é: {0}", result);

                        break;

                }

                Console.WriteLine("Deseja voltar ao menu principal ? (S ou N)");
                escolha = Console.ReadLine();
            } while (escolha == "S" || escolha == "s");
        }
    }
}
