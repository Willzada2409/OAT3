using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade30
    {
        public void atividade_30()
        {
            Console.WriteLine("Me informe a tabuada que deseja ver (1 a 10");
            int tabuada = int.Parse(Console.ReadLine());

            while (tabuada < 1 || tabuada > 10)
            {
                Console.Write("Tabuada selecionada não está disponivel, informe novamente");
                tabuada = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 10; i++)
            {
                int result = tabuada * i;
                Console.WriteLine("A tabuada do número {0} é: {1} x {2} = {3}", tabuada, tabuada, i, result);
            }
            Console.ReadKey();

        }
    }
}
