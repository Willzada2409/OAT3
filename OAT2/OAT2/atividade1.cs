using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade1
    {
        public void atividade_1()
        {
            Console.WriteLine("Me informe o nome da peça que deseja ver o estoque médio");
            string peca = Console.ReadLine();
            Console.WriteLine("Informe a quantidade mínima do estoque");
            int minima = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade máxima do estoque");
            int maximo = int.Parse(Console.ReadLine());

            int media = (minima + maximo) / 2;

            Console.WriteLine("A quantidade média do(a) {0} no estoque é: {1}", peca, media);
            Console.ReadKey();
        }
    }
}
