using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade15
    {
        public void atividade_15() 
        {
            Console.WriteLine("Informe a primeira nota (0 a 10)");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota (0 a 10)");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota (0 a 10)");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota (0 a 10)");
            double nota4 = double.Parse(Console.ReadLine());

            while (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10)
            {
                Console.WriteLine("Alguma das notas está com o valor incorreto, informe as 4 notas novamente");
                nota1 = double.Parse(Console.ReadLine());
                nota2 = double.Parse(Console.ReadLine());
                nota3 = double.Parse(Console.ReadLine());
                nota4 = double.Parse(Console.ReadLine());
            }
                double media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (media >= 7)
                {
                    Console.WriteLine("Parabéns, aluno aprovado com a média {0}", media);
                }
                else
                {
                    Console.WriteLine("O aluno não alcançou a média, me informe a nota da recuperação (1 a 10)");
                    double rec = double.Parse(Console.ReadLine());
                    
                    while (rec < 0 || rec > 10)
                {
                    Console.WriteLine("Valor da recuperação não existe, informe novamente");
                    rec = double.Parse(Console.ReadLine());
                }

                    media = (nota1 + nota2 + nota3 + nota4 + rec) / 5;
                    if (media >= 7)
                    {
                        Console.WriteLine("Parabéns, aluno aprovado na recuperação com média {0}", media);
                    }
                    else
                    {
                        Console.WriteLine("Que pena, aluno reprovado com a média {0}. Estude mais", media);
                    }
                }
            
            Console.ReadKey();
        }
    }
}
