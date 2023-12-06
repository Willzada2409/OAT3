using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class atividade62
    {
        public void atividade_62()
        {
            Console.WriteLine("Informe o valor da base do triângulo");
            double basE = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura do triângulo");
            double altura = double.Parse(Console.ReadLine());

            double hipotenusa = Hipotenusa(basE, altura);

            Console.WriteLine("O valor da hipotenusa com base nos dados fornecidos do triângulo é: {0}", hipotenusa);

            Console.ReadKey();

        }

        public double Hipotenusa(double basE, double altura)
        {
            double hipotenusaQ = Math.Pow(basE, 2) + Math.Pow(altura, 2);

            double hipotenusa = Math.Sqrt(hipotenusaQ);

            return hipotenusa;
        }
    }
}
