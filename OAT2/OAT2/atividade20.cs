using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade20
    {
        public void atividade_20()
        {
         int a = 0;
         int b = 0;
         int c = 0;

            Console.WriteLine("Me informe 3 valores");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            while (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Algum dos valores não é válido, informe novamente");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            }

            if (a < b && a < c &&  b < c)
            {
                double d = a * c;
                double e = c / a;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }
            else if (b < a && b < c && a < c)
            {
                double d = b * c;
                double e = c / b;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }
            else if (c < a && c < b && a < b)
            {
                double d = c * b;
                double e = b / c;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }
            else if (b < a && b < c && c < a)
            {
                double d = b * a;
                double e = a / b;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }
            else if (a < b && a < c && c < b)
            {
                double d = a * b;
                double e = b / a;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }
            else if (c < a && c < b && b < a)
            {
                double d = c * a;
                double e = a / c;
                Console.WriteLine("O resultado do menor valor multiplicado pelo maior é {0}", d);
                Console.WriteLine("");
                Console.WriteLine("O resultado do maior valor dividido pelo menor é {0}", e);
            }

            Console.ReadKey();
        }
    }
}
