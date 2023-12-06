using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade41
    {
        public void atividade_41()
        {
            Console.WriteLine("Me informe a idade do nadador:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Nadador da categoria Infantil A");
            }
            else if (idade >= 8 && idade <= 11) 
            {
                Console.WriteLine("Nadador da categoria Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Nadador da categoria Juvenil a");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Nadador da categoria Juvenil B");
            }
            else if (idade >= 18 )
            {
                Console.WriteLine("Nadador da categoria Adulto");
            }
            else
            {
                Console.WriteLine("Nadador ainda é muito jovem, não possui uma categoria");
            }
            Console.ReadKey();

        }
    }
}
