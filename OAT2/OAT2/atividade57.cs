using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade57
    {
        public void atividade_57()
        {
            Console.WriteLine("Informe a frase");
            string frase = Console.ReadLine();

            string vogal = "";

            foreach (char c in frase)
            {
                if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                {
                    vogal += c;
                }
            }

            Console.WriteLine("Essas são somente as vogais: {0}", vogal);

            Console.ReadKey();

        }
    }
}
