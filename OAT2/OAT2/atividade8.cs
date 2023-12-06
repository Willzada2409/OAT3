using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade8
    {
        public void atividade_8()
        {
            Console.WriteLine(" Para calcularmos o volume preciso que me informe o Raio e a altura da lata de óleo");
            
            Console.WriteLine("Informe o Raio");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora me informe a altura");
            double altura = double.Parse(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("O volume da lata de óleo é {0}", volume);

            Console.ReadKey();
        }
    }
}
