using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade64
    {
        public int[] vetor;
        public void atividade_64()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha uma das opções a seguir:");
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        CarregarVetor();

                        break; 
                    
                    case 2:
                        ListarVetor();

                        break; 
                    
                    case 3:
                        Par();

                        break;

                    case 4:
                        Impar();

                        break;

                    case 5:
                        PosicaoI();

                        break;
                    
                    case 6:
                        PosicaoP();

                        break;

                    case 7:
                        Console.WriteLine("O programa será encerrado");

                        break;
                }


            } while (opcao != 7);
        }

        public void CarregarVetor()
        {
            Console.WriteLine("Digite o tamanho do vetor");
            int tamanho = int.Parse(Console.ReadLine());

            vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe o valor da posição {0}", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ListarVetor()
        {
            
            if (vetor == null)
            {
                Console.WriteLine("O vetor está vazio, primeiro carregue ele");
                return;
            }
            Console.WriteLine("Esses são os números do vetor:");
            foreach (int numero in vetor)
            {
                Console.WriteLine($"{numero}");
            }

            Console.WriteLine("");
        }

        public void Par()
        {
            
            if (vetor == null)
            {
                Console.WriteLine("O vetor está vazio, primeiro carregue ele");
                return;
            }

            Console.WriteLine("Esses são os números pares do Vetor:");

            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " ");
                }
            }
            Console.WriteLine("");
        }

        public void Impar()
        {
            
            if (vetor == null)
            {
                Console.WriteLine("O vetor está vazio, primeiro carregue ele");
                return;
            }

            Console.WriteLine("Esses são os números impares do Vetor:");

            foreach (int numero in vetor)
            {
                if (numero % 2 != 0 )
                {
                    Console.WriteLine(numero + " ");
                }
            }
            Console.WriteLine("");
        }

        public void PosicaoI()
        {
            
            if (vetor == null)
            {
                Console.WriteLine("O vetor está vazio, primeiro carregue ele");
                return;
            }

            int contador = 0;

            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de números pares nas posições ímpares: {0}", contador);
            Console.WriteLine("");
        }

        public void PosicaoP()
        {
            ;
            if (vetor == null)
            {
                Console.WriteLine("O vetor está vazio, primeiro carregue ele");
                return;
            }

            int contador = 0;

            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de números ímpares nas posições pares: {0}", contador);
            Console.WriteLine("");
        }
    }
}
