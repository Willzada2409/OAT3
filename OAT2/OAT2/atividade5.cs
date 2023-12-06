using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade5
    {
        public void atividade_5()
        {
            Console.WriteLine("Me informa o tempo da viagem (Em Horas)");
            double tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Me informe a velocidade média (em km/h)");
            double velocidade = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;

            double litros = distancia / 12;

            Console.WriteLine("Você levou {0} horas com uma velocidade média de {1} Km/h ", tempo, velocidade);
            Console.WriteLine("");
            Console.WriteLine("A distancia percorrida foi de {0} quilometros e o total de litros de combustível gasto foi de {1} litros ", distancia, litros);

            Console.ReadKey();

        }
    }
}
