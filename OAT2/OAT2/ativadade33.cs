using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade33
    {
        public void atividade_33()
        {
            int quantA = 0;
            double soma = 0;

            Console.WriteLine("Digite as notas dos alunos (digite -1 para encerrar):");

            while (true)
            {
                Console.WriteLine("Informe o número da matrícula: ");
                int numM = int.Parse(Console.ReadLine());

                if (numM == -1 ) 
                {
                    break;
                }

                Console.WriteLine("Informe a nota: ");
                double nota = double.Parse(Console.ReadLine());

                while (nota < 0 || nota > 10) 
                {
                    Console.WriteLine("Valor de nota inválido, informe novamente");
                    nota = double.Parse(Console.ReadLine());
                }

                quantA++;
                soma += nota;
            }

            if (quantA > 0)
            {
                double media = soma / quantA;
                Console.WriteLine("A média dos alunos da turma é: {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhum aluno foi inserido.");
            }
            Console.ReadKey();
        }
    }
}
