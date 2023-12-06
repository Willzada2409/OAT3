using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade55
    {
        public void atividade_55()
        {
            Console.WriteLine("Digite uma frase de até 50 caracteres:");
            string frase = Console.ReadLine();

            
            while (frase.Length > 50)
            {
                Console.WriteLine("A frase deve ter no máximo 50 caracteres, digite novamente");
                frase = Console.ReadLine();
            }

            
            int quantEspaco = 0;

            
            string semEspaco = "";
            foreach (char caractere in frase)
            {
                if (caractere != ' ')
                {
                    semEspaco += caractere;
                }
                else
                {
                    quantEspaco++;
                }
            }

            
            Console.WriteLine("Frase sem espaços: {0}",semEspaco);
            Console.WriteLine("Quantidade de espaços removidos: {0}", quantEspaco);

            Console.ReadKey();
        }
    }
}
