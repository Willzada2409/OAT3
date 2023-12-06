using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade7
    {
        public void atividade_7()
        {
            Console.WriteLine("Informe a temperatura em Fahrenheit");
            double fahre = double.Parse(Console.ReadLine());

            double celsius = (fahre - 32) * 5 / 9;

            Console.WriteLine("A temperatura convertida para celsius é {0} graus", celsius);

            Console.ReadKey();
        }
    }
}
