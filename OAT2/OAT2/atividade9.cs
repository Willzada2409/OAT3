using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade9
    {
        public void atividade_9()
        {
            Console.WriteLine("Me informe sua idade em anos, meses e dias");
            int anos = int.Parse(Console.ReadLine());
            int meses = int.Parse(Console.ReadLine());
            int dias = int.Parse(Console.ReadLine());

            int idade = anos * 365 + meses * 30 + dias;

            Console.WriteLine("Sua idade convertida em dias é {0} dias", idade);

            Console.ReadKey();
        }
    }
}
