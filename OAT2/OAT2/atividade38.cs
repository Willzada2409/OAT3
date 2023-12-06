using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade38
    {
        public void atividade_38()
        {
            string escolha = "S";

            do
            {
                Console.WriteLine("Insira o código");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o tanto de horas trabalhadas");
                int n = int.Parse(Console.ReadLine());

                double salario = 0;

                int horasExtras = 0;
                double salarioExtra = 0;

                if (n > 50)
                {
                    horasExtras = n - 50;
                    salario = 50 * 10;
                    salarioExtra = horasExtras * 20;
                }
                else
                {
                    salario = 50 * 10;
                }

                double total = salario + salarioExtra;

                Console.WriteLine("Seu salário total foi de: {0}", total);
                Console.WriteLine("Seu salário extra foi de: {0}", salarioExtra);

                Console.WriteLine("Deseja continuar ? (S ou N)");
                escolha = Console.ReadLine();



            } while (escolha == "S");
        }
    }
}
