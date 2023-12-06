using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade52
    {
        public void atividade_52()
        {
            
            
            
            

            

                int maximo = 100;

                Console.WriteLine("Informe o tamanho do vetor (1 a 100)");
                int tamanho = int.Parse(Console.ReadLine());
                int[] num = new int[tamanho];

                 while (tamanho > maximo)
                {
                    Console.WriteLine("Tamanho do vetor é maior que o permitido");
                    tamanho = int.Parse(Console.ReadLine());
                }

                

                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine("Informe o número da posição {0}, para parar o programa digite -1", i + 1);
                    num[i] = int.Parse(Console.ReadLine());

                    if (num[i] == -1)
                {
                    break;
                }

                    if (num[i] < -1)
                {
                    Console.WriteLine("Só é permitido números positivos, informe novamente");
                    num[i] = int.Parse(Console.ReadLine());
                }
                
                }
                


            

            int quantUm = 0;
            int quantTres = 0;
            int quantQuatro = 0;

            for (int i = 0;i < tamanho;i++)
            {
                if (num[i] == 1)
                {
                    quantUm++;
                }
                else if (num[i] == 3)
                {
                    quantTres++;
                }
                else if (num[i] == 4)
                {
                    quantQuatro++;
                }

                
            }
            Console.WriteLine("O número 1 aparece {0} vez(es)", quantUm);
            Console.WriteLine("O número 3 aparece {0} vez(es)", quantTres);
            Console.WriteLine("O número 4 aparece {0} vez(es)", quantQuatro);

            Console.ReadKey();
        }
    }
}
