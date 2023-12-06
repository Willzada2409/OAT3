using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade61
    {
        public void atividade_61()
        {
            Console.WriteLine("Me informe o valor do salário");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o indice de reajuste (em %)");
            double indice = double.Parse(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indice);

            Console.WriteLine("O salário após o reajuste fica no valor de: R$ {0} reais", salarioAtualizado);

            Console.ReadKey();
        }
        public double Reajuste (double salario, double indice)
        {
            double reajuste = salario * (indice / 100);

            double salarioTotal = salario + reajuste;

            return salarioTotal;
        }
    }
}
