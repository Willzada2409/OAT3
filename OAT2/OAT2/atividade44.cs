using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade44
    {
        public void atividade_44()
        {
            string resposta = "";

            do
            {

                Console.WriteLine("Escola uma das opções:");
                Console.WriteLine("1- Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2- Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3- Peso ideal do homem");
                Console.WriteLine("4- Peso ideal da mulher");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Me informe a temperatura em graus Celsius ");
                        double celsius = double.Parse(Console.ReadLine());

                        double fahre = (9 * celsius + 160) / 5;

                        Console.WriteLine("A temperatura convertida em Fahrenheit é {0} ", fahre);

                        break;

                    case 2:
                        
                        Console.WriteLine("Informe a temperatura em Fahrenheit");
                         fahre = double.Parse(Console.ReadLine());

                         celsius = (fahre - 32) * 5 / 9;

                        Console.WriteLine("A temperatura convertida para celsius é {0} graus", celsius);

                        break;

                    case 3:

                        Console.WriteLine("Me informe sua altura (em metros)");
                        double altura = double.Parse(Console.ReadLine());

                        double pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine("Seu peso ideial é {0}", pesoIdeal);

                        Console.WriteLine("Me informe seu peso atual:");
                        double pesoAtual = double.Parse(Console.ReadLine());

                        if (pesoAtual > pesoIdeal + 10)
                        {
                            Console.WriteLine("Você está acima do peso");
                        }
                        else if (pesoAtual < pesoIdeal - 10)
                        {
                            Console.WriteLine("Você está abaixo do peso");
                        }
                        else
                        {
                            Console.WriteLine("Você está no peso ideal");
                        }


                        break;

                    case 4:


                        Console.WriteLine("Me informe sua altura (em metros)");
                        altura = double.Parse(Console.ReadLine());

                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine("Seu peso ideial é {0}", pesoIdeal);

                        Console.WriteLine("Me informe seu peso atual:");
                        pesoAtual = double.Parse(Console.ReadLine());

                        if (pesoAtual > pesoIdeal + 6)
                        {
                            Console.WriteLine("Você está acima do peso");
                        }
                        else if (pesoAtual < pesoIdeal - 6)
                        {
                            Console.WriteLine("Você está abaixo do peso");
                        }
                        else
                        {
                            Console.WriteLine("Você está no peso ideal");
                        }

                        break;
                }

                Console.WriteLine("Deseja encerrar o código ? (S ou N)");
                resposta = Console.ReadLine();

            } while (resposta != "S");
        }
    }
}
