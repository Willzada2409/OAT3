using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade51
    {
        public void atividade_51()
        {

            Console.WriteLine("Me informe a quantidade de alunos que deseja verificar a nota");
            int tamanho = int.Parse(Console.ReadLine());

            
            double[] nota = new double[tamanho];
            double media = 0;
            int contador = 0;
            double soma = 0;
            int contador2 = 0;

            for (int i = 0; i < tamanho; i++)
            {

                Console.WriteLine("Me informe a nota do aluno {0}", i + 1);
                nota[i] = double.Parse(Console.ReadLine());
                while (nota[i] < 0 || nota[i] > 10)
                {
                    Console.WriteLine("Nota inválida, informe novamente");
                    nota[i] = int.Parse(Console.ReadLine());
                }

                soma += nota[i];

                if (nota[i] > 7)
                {
                    contador++;
                }
                else if (nota[i] > 5 && nota[i] <= 7) 
                {
                    contador2++;
                }
 
            }

            media = soma / tamanho;

            Console.WriteLine("A média das notas dos alunos é: {0}", media);
            
                if (contador > 0)
                {
                    Console.WriteLine("Um total de {0} aluno(s) tiraram acima de 7", contador);
                }
            if (contador2 == 0 && contador == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5");
            }
                
                
            Console.ReadKey();



        }
    }
}
