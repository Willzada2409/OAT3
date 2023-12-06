using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade2
    {
        public void atividade_2()
        {
            Console.WriteLine("Me informe a cotação do dólar");
            double cotDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você possui ?");
            double dolar = double.Parse(Console.ReadLine());

            double real = cotDolar * dolar;

            Console.WriteLine("A quantidade de dolares que você possui convertidos para real é {0} reais", real);

            Console.ReadKey();

        }
    }
}
