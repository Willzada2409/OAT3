using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade18
    {
        public void atividade_18()
        {
            Console.WriteLine("Me informe um número");
            int CODIGO = int.Parse(Console.ReadLine());

            while (CODIGO < 1 ||  CODIGO > 3)
            {
                Console.WriteLine("Código inválido, informe novamente");
                CODIGO = int.Parse(Console.ReadLine());
            }

            switch (CODIGO)
            {
                case 1:
                    Console.WriteLine("um");

                    break;

                    case 2:
                    Console.WriteLine("dois");

                    break;

                    case 3:
                    Console.WriteLine("três");

                    break;
            }
            Console.ReadKey();
        }
    }
}
