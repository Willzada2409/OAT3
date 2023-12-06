using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade6
    {
        public void atividade_6()
        {
            Console.WriteLine("Me informe a temperatura em graus Celsius ");
            double celsius = double.Parse(Console.ReadLine());

            double fahre = (9 * celsius + 160) / 5;

            Console.WriteLine("A temperatura convertida em Fahrenheit é {0} ", fahre);

            Console.ReadKey();
        }
    }
}
