using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade11
    {
        public void atividade_11()
        {
            Console.WriteLine("Me informe o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            int B = int.Parse(Console.ReadLine());

            int C = A;
            A = B;
            B = C;

            Console.WriteLine("Os valores trocados ficam assim A = {0} e B = {1}", A, B);

            Console.ReadKey();
        }
    }
}
