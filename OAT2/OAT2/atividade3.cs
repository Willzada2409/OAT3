using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade3
    {
        public void atividade_3()
        {
            Console.WriteLine("Me informe o nome do vendedor");
            string vendedor = Console.ReadLine();

            Console.WriteLine("Me informe o código da peça");
            int peca = int.Parse(Console.ReadLine());

            Console.WriteLine("Me informe o valor unitário dessa peça");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe qual foi a quantidade vendida");
            int quant = int.Parse(Console.ReadLine());

            double vendas = quant * valor;

            double comissao = vendas * 0.05;

            Console.WriteLine("{0} você vendeu um total de R${1} reais da peça {2} e sua comissão por essa quantidade é de R${3} reais", vendedor, vendas, peca, comissao);

            Console.ReadKey();

        }
    }
}
